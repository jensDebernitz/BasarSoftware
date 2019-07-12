using System;
using MaterialSkin.Controls;
using NetworkCommsDotNet;
using CustomDataObjects;
using NetworkCommsDotNet.Connections;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Drawing.Printing;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BasarClient
{
    public partial class MainView : MaterialForm
    {
        private ViewModel _Model = new ViewModel();
        string barcode;
        private double _TotalPrice = 0;

        public MainView()
        {
            InitializeComponent();

            InitDataBindings();
            InitNetwork();

            materialTabControl1.SelectedIndex = 1;
            textBox1.Focus();


        }
        private void InitDataBindings()
        {
            textFieldIp.DataBindings.Add("Text", _Model, "ServerIpAddresse", true, DataSourceUpdateMode.OnPropertyChanged);
            textFieldSellerPort.DataBindings.Add("Text", _Model, "SellerClientPort", true, DataSourceUpdateMode.OnPropertyChanged);
            materialSingleLineTextField1.DataBindings.Add("Text", _Model, "BasarName", true, DataSourceUpdateMode.OnPropertyChanged);
            materialSingleLineTextField2.DataBindings.Add("Text", _Model, "NextBasarDate", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitNetwork()
        {
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageSellerIdFromPartNotFound", IncomingMessage);
            NetworkComms.AppendGlobalIncomingPacketHandler<PartInformations>("MessageSellerIsFound", IncomingMessagePartInformations);

            Connection.StartListening(ConnectionType.TCP, new System.Net.IPEndPoint(System.Net.IPAddress.Any, Convert.ToInt32(_Model.SellerClientPort)));

            //Print out the IPs and ports we are now listening on
            Console.WriteLine("Server listening for TCP connection on:");
            foreach (System.Net.IPEndPoint localEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
            {
                Console.WriteLine("{0}:{1}", localEndPoint.Address, localEndPoint.Port);
            }

        }

        private void IncomingMessagePartInformations(PacketHeader packetHeader, Connection connection, PartInformations incomingObject)
        {
            switch (packetHeader.PacketType)
            {
                case "MessageSellerIsFound":
                    Invoke(new Action(() => 
                    {
                        DialogResult result = MessageBox.Show("Betrag: " + incomingObject.PartPrice.ToString(), "Bitte bestätigen", MessageBoxButtons.OKCancel);

                        if(result == DialogResult.OK)
                        {
                            ListViewItem item = new ListViewItem(incomingObject.PartDescription);
                            item.SubItems.Add(incomingObject.PartNumber.ToString());
                            item.SubItems.Add(incomingObject.PartPrice.ToString() + "€");

                            listView1.Items.Add(item);
                            labelPartPrice.Text = incomingObject.PartPrice.ToString() + "€";
                            _TotalPrice += incomingObject.PartPrice;

                            labelTotalPrice.Text = _TotalPrice.ToString() + "€";
                            textBox1.Focus();
                            NetworkComms.SendObject("MessagePartInformationsConfirmed", _Model.ServerIpAddresse, Convert.ToInt32(_Model.ServerPort), incomingObject);
                        }


                    }));

                    break;
            }

        }

        private void IncomingMessage(PacketHeader packetHeader, Connection connection, string incomingObject)
        {
            switch (packetHeader.PacketType)
            {
                case "MessageSellerIdFromPartNotFound":
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show(incomingObject);
                        textBox1.Focus();
                    }));
                    break;
            }
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            NetworkComms.Shutdown();
            Close();
        }

        private void materialRaisedButton3_Click_1(object sender, EventArgs e)
        {
            ManuelleEingabe manuelleEingabe = new ManuelleEingabe();

            if(DialogResult.OK == manuelleEingabe.ShowDialog())
            {
                int partnumber = manuelleEingabe.PartNumber();
                int sellerId = manuelleEingabe.SellerId();
                double price = manuelleEingabe.Price();

                SendPortInformationsToServer(partnumber, sellerId, price, "Der Artikel wurde Manuell eingegeben");
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Wollen sie nun Abschliessen?", "Abschliessen?", MessageBoxButtons.YesNo);

            if(result == System.Windows.Forms.DialogResult.Yes)
            {

                result = MessageBox.Show("Wollen sie eine Quittung drucken?", "Quittung?", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(".\\temp.pdf", FileMode.Create));
                    document.Open();

                    var myFont11 = FontFactory.GetFont("NewJune", 18, BaseColor.BLACK);
                    var p1 = new Paragraph("Kinder und Kleiderbasar "+ materialSingleLineTextField1.Text + ".\n", myFont11);
                    document.Add(p1);

                    PdfPTable table1 = new PdfPTable(2);
                    table1.SpacingBefore = 50;

                    var myFont111 = FontFactory.GetFont("NewJune", 25, BaseColor.BLACK);
                    table1.AddCell(new PdfPCell(new Phrase("Artikelnummer:", myFont111)));
                    table1.AddCell(new PdfPCell(new Phrase("Preis:", myFont111)));


                    document.Add(table1);

                    document.Close();

                    ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                    {
                        Verb = "print",
                        CreateNoWindow = true,
                        FileName = ".\\j.pdf",
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process printProcess = new Process();
                    printProcess.StartInfo = printProcessInfo;
                    printProcess.Start();

                    printProcess.WaitForInputIdle();

                    Thread.Sleep(3000);

                    if (false == printProcess.CloseMainWindow())
                    {
                        printProcess.Kill();
                    }
                }

                listView1.Items.Clear();
                labelPartPrice.Text = "0,00 €";
                _TotalPrice = 0;
                labelTotalPrice.Text = "0,00 €";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(textBox1.Text);

            if(textBox1.Text.Length == 12)
            {
                barcode = textBox1.Text;
                textBox1.Text = String.Empty;

                string sellerId = barcode.Substring(0, 4);
                string partNumber = barcode.Substring(4, 3);
                
                string price = barcode.Substring(7, 5);

                int sellerIdInt = Convert.ToInt32(sellerId);
                int partNumberInt = Convert.ToInt32(partNumber);
                double priceDouble = Convert.ToDouble(Convert.ToInt32(price) / 100.0);

                SendPortInformationsToServer(partNumberInt, sellerIdInt, priceDouble, "Der Artikel wurde gescannt eingegeben");
                textBox1.Focus();
            }
        }

        private void SendPortInformationsToServer(int partNumber, int sellerId, double price, string info)
        {
            PartInformations partInformations = new PartInformations(partNumber, info, price, sellerId);

            //Send it to Server... :-)
            NetworkComms.SendObject("MessagePartInformations", _Model.ServerIpAddresse, Convert.ToInt32(_Model.ServerPort), partInformations);
        }
    }
}

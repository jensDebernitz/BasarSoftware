using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkCommsDotNet;
using CustomDataObjects;
using MaterialSkin.Controls;
using NetworkCommsDotNet.Connections;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasarAdministration
{
    public partial class MainView : MaterialForm
    {
        private ViewModel _Model = new ViewModel();
//         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series
//         {
//             Name = "Series1",
//             Color = System.Drawing.Color.Green,
//             IsVisibleInLegend = false,
//             IsXValueIndexed = true
//         };

        int _CountAtNine;
        int _CountAtTen;
        int _CountAtEleven;
        int _CountAtTwelve;
        int _CountAtThirteen;

        public MainView()
        {
            InitializeComponent();
            InitNetwork();
            InitDataBindings();
            comboBox1.SelectedIndex = 1;
        }

        private void InitDataBindings()
        {
            textFieldIp.DataBindings.Add("Text", _Model, "ServerIpAddresse", true, DataSourceUpdateMode.OnPropertyChanged);
            textFieldAdminClientPort.DataBindings.Add("Text", _Model, "AdminClientPort", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitNetwork()
        {
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageSellerIdNotFound", IncomingMessage);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageNewSellerId", IncomingMessage);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageSellerCount", IncomingMessage);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageSellerListStart", IncomingMessage);
            NetworkComms.AppendGlobalIncomingPacketHandler<Seller>("MessageSellerList", IncomingMessageSeller);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageStatistikListStart", IncomingMessage);
            NetworkComms.AppendGlobalIncomingPacketHandler<Statistik>("MessageStatistikList", IncomingMessageStatistik);

            Connection.StartListening(ConnectionType.TCP, new System.Net.IPEndPoint(System.Net.IPAddress.Any, Convert.ToInt32(_Model.AdminClientPort)));

            //Print out the IPs and ports we are now listening on
            Console.WriteLine("Server listening for TCP connection on:");
            foreach (System.Net.IPEndPoint localEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
            {
                Console.WriteLine("{0}:{1}", localEndPoint.Address, localEndPoint.Port);
            }

        }

        private void IncomingMessageSeller(PacketHeader packetHeader, Connection connection, Seller incomingObject)
        {
            switch (packetHeader.PacketType)
            {
                case "MessageSellerList":
                    listViewSearchResult.Invoke(new Action(() =>
                        {
                            ListViewItem item = new ListViewItem(incomingObject.SellerId.ToString());
                            item.SubItems.Add(incomingObject.SellerGivenName);
                            item.SubItems.Add(incomingObject.SellerSureName);
                            item.SubItems.Add(incomingObject.Email);

                            listViewSearchResult.Items.Add(item);
                        }));

                    break;
            }
        }

        private void IncomingMessageStatistik(PacketHeader packetHeader, Connection connection, Statistik incomingObject)
        {
            switch (packetHeader.PacketType)
            {
                case "MessageStatistikList":
                    Invoke(new Action(() =>
                    {
                        if(incomingObject.SellDateTime.Hour == 9)
                        {
                            _CountAtNine++;
                        }
                        else if (incomingObject.SellDateTime.Hour == 10)
                        {
                            _CountAtTen++;
                        }
                        else if (incomingObject.SellDateTime.Hour == 11)
                        {
                            _CountAtEleven++;
                        }
                        else if (incomingObject.SellDateTime.Hour == 12)
                        {
                            _CountAtTwelve++;
                        }
                        else if (incomingObject.SellDateTime.Hour == 13)
                        {
                            _CountAtThirteen++;
                        }
                    }));

                    break;
            }
        }

        private void IncomingMessage(PacketHeader packetHeader, Connection connection, string incomingObject)
        {
            switch(packetHeader.PacketType)
            {
                case "MessageSellerIdNotFound":
                    MessageBox.Show(incomingObject);
                    break;
                case "MessageNewSellerId":
                    
                    textFieldSellerId.Invoke(new Action(() =>
                    {
                        textFieldSellerId.Text = incomingObject;
                        MessageBox.Show("Es wurde eine neue Verkäufernummer generiert.");
                    }));

                    
                    break;
                case "MessageSellerCount":
                    labelSellerCount.Invoke(new Action(() =>
                    {
                        labelSellerCount.Text = incomingObject;
                    }));
                    break;
                case "MessageSellerListStart":
                    listViewSearchResult.Invoke(new Action(() =>
                    {
                        listViewSearchResult.Items.Clear();
                    }));
                    break;

                case "MessageStatistikListStart":
                    Invoke(new Action(() =>
                    {
                        if (incomingObject == "true")
                        {
                            _CountAtNine = 0;
                            _CountAtTen = 0;
                            _CountAtEleven = 0;
                            _CountAtTwelve = 0;
                            _CountAtThirteen = 0;
                            chart1.Series[0].Points.Clear();
                        }
                        else
                        {
                            chart1.Series[0].Points.AddXY(9, _CountAtNine);
                            chart1.Series[0].Points.AddXY(10, _CountAtTen);
                            chart1.Series[0].Points.AddXY(11, _CountAtEleven);
                            chart1.Series[0].Points.AddXY(12, _CountAtTwelve);
                            chart1.Series[0].Points.AddXY(13, _CountAtThirteen);

                            chart1.Invalidate();
                        }
                    }));
                    break;
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            NetworkComms.Shutdown();
            Close();
        }

        private void buttonErfassen_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(textFieldSellerId.Text) == true)
            {
                DialogResult result = MessageBox.Show("Wenn die Verkäufer Id leer gelassen wird,\r\nwird eine Verkäufer Id neu vergeben!", "Achtung", MessageBoxButtons.YesNo);

                if(result == DialogResult.No)
                {
                    return;
                }
            }

            if(    String.IsNullOrEmpty(textFieldGivenName.Text) == true
                || String.IsNullOrEmpty(textFieldSureName.Text) == true
                || String.IsNullOrEmpty(textFieldStreet.Text) == true
                || String.IsNullOrEmpty(textFieldHouseNumber.Text) == true
                || String.IsNullOrEmpty(textFieldPostalCode.Text) == true
                || String.IsNullOrEmpty(textFieldVillage.Text) == true)
            {
                MessageBox.Show("Sie haben nicht alle Daten erfasst");
            }
            else
            {
                int sellerId = -1;

                if (String.IsNullOrEmpty(textFieldSellerId.Text) == false)
                {
                    sellerId = Convert.ToInt32(textFieldSellerId.Text);
                }

                CustomDataObjects.Seller seller = new CustomDataObjects.Seller(sellerId,
                                                                                textFieldGivenName.Text,
                                                                                textFieldSureName.Text,
                                                                                textFieldStreet.Text + " " + textFieldHouseNumber.Text,
                                                                                textFieldPostalCode.Text + " " + textFieldVillage.Text,
                                                                                textFieldSellerEmail.Text);

                NetworkComms.SendObject("MessageSeller", _Model.ServerIpAddresse, Convert.ToInt32(_Model.ServerPort), seller);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Items[comboBox1.SelectedIndex].ToString().ToLower())
            {
                case "verkäuferid":

                    labelFirstFilter.Text = "VerkäuferId";

                    labelSecondFilter.Visible = false;
                    textFieldSecondFilter.Visible = false;
                    break;
                case "name":
                    labelFirstFilter.Text = "Vorname";

                    labelSecondFilter.Visible = true;
                    textFieldSecondFilter.Visible = true;
                    break;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SellerDataBase sellerDataBase = new SellerDataBase();

            string sendMessage = "";


            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString().ToLower())
            {
                case "verkäuferid":
                    sendMessage = textFieldFirstFilter.Text;
                    break;
                case "name":
                    sendMessage = textFieldFirstFilter.Text + ";" + textFieldSecondFilter.Text;
                    break;
            }

            NetworkComms.SendObject("MessageSellerFind", _Model.ServerIpAddresse, Convert.ToInt32(_Model.ServerPort), sendMessage);
        }

        private void timerHeartBeat_Tick(object sender, EventArgs e)
        {
            try
            {
                NetworkComms.SendObject("MessageHeartBeat", _Model.ServerIpAddresse, Convert.ToInt32(_Model.ServerPort), DateTime.Now.ToShortTimeString());
            }
            catch (System.Exception ex)
            {
                ex.GetType();
                MessageBox.Show("Es besteht momentan keine Verbindung zum Server");
            }
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Access (*.mdb)|*.mdb";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable userTables = null;
                string fileName = openFileDialog1.FileName;
                string conString =
                                    @"Provider=Microsoft.JET.OLEDB.4.0;"
                                   + @"data source=" + fileName;

                OleDbConnection oleDbConnection = new OleDbConnection(conString);

                oleDbConnection.Open();

                // create the DataSet
                DataSet dataSet = new DataSet();
                OleDbDataAdapter adapter =
                        new OleDbDataAdapter("Select * from Verkäuferdaten", oleDbConnection);
                adapter.Fill(dataSet);

                DataSet dataSetNumbers = new DataSet();
                OleDbDataAdapter adapterNumbers =
                        new OleDbDataAdapter("Select * from Verkaufsnummern", oleDbConnection);
                adapterNumbers.Fill(dataSetNumbers);

                oleDbConnection.Close();

                DataTable dt = dataSet.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    Debug.WriteLine(dr["ID"].ToString() + " " + dr["Verkäufer_Name"].ToString());

                    string name = dr["Verkäufer_Name"].ToString();
                    string[] splittedName = name.Split(' ');

                    string streetHouseNumber = dr["Verkäufer_Straße"].ToString();

                    string villagePostalCode = dr["Verkäufer_Ort"].ToString();

                    InputForm inputForm;

                    if (splittedName.Length == 1)
                    {
                        inputForm = new InputForm("In den Namensdaten [ " + splittedName[0] + "] ist ein Fehler aufgedrehten", "Vorname", "Nachname");

                        if(inputForm.ShowDialog() == DialogResult.OK)
                        {
                            inputForm.GetTexts(ref splittedName);
                        }
                    }

                    CustomDataObjects.Seller seller = new CustomDataObjects.Seller(Convert.ToInt32(dr["ID"]),
                                                                        splittedName[0],
                                                                        splittedName[1],
                                                                        streetHouseNumber,
                                                                        villagePostalCode,
                                                                        dr["Verkäufer_EMail"].ToString());
                    seller.CreateNewSeller = true;

                    DataTable dt2 = dataSetNumbers.Tables[0];
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        int sellerId1 = Convert.ToInt32(dr2["Verkäufer_ID"]);
                        int sellerId2 = Convert.ToInt32(dr["ID"]);

                        if (sellerId1 == sellerId2)
                        {
                            seller.SaleNumbers.Add(Convert.ToInt32(dr2["Verkaufsnr"]));
                        }
                    }

                    NetworkComms.SendObject("MessageSeller", _Model.ServerIpAddresse, Convert.ToInt32(_Model.ServerPort), seller);
 
                }

            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            NetworkComms.SendObject("MessageGetStatistik", _Model.ServerIpAddresse, Convert.ToInt32(_Model.ServerPort), "true");
        }
    }
}

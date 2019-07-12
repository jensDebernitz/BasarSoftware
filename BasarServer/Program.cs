using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using CustomDataObjects;
using System.Net;

namespace BasarServer
{
    class Program
    {
        static void Main(string[] args)
        {
            InitDataBase();
            InitNetwork();
            EndlessLoop();
        }

        private static void EndlessLoop()
        {

            //Let the user close the server
            Console.WriteLine("\nPress any key to close server.");
            Console.ReadKey(true);

            //We have used NetworkComms so we should ensure that we correctly call shutdown
            NetworkComms.Shutdown();
        }

        private static void InitDataBase()
        {
            DataBase.DataBase.Init(AppDomain.CurrentDomain.BaseDirectory);
        }

        private static void InitNetwork()
        {
            NetworkComms.AppendGlobalIncomingPacketHandler<PartInformations>("MessagePartInformations", IncomingMessagePartInformations);
            NetworkComms.AppendGlobalIncomingPacketHandler<PartInformations>("MessagePartInformationsConfirmed", IncomingMessagePartInformations);
            NetworkComms.AppendGlobalIncomingPacketHandler<Seller>("MessageSeller", IncomingMessageSeller);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageSellerFind", IncomingMessageString);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageHeartBeat", IncomingMessageString);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("MessageGetStatistik", IncomingMessageString);


            Connection.StartListening(ConnectionType.TCP, new System.Net.IPEndPoint(System.Net.IPAddress.Any, 51948));

            //Print out the IPs and ports we are now listening on
            Console.WriteLine("Server listening for TCP connection on:");
            foreach (System.Net.IPEndPoint localEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
            {
                Console.WriteLine("{0}:{1}", localEndPoint.Address, localEndPoint.Port);
            }

        }

        private static void IncomingMessageString(PacketHeader packetHeader, Connection connection, string incomingObject)
        {
            IPEndPoint remoteIpEndPoint = connection.ConnectionInfo.RemoteEndPoint as IPEndPoint;
            string addresse = remoteIpEndPoint.Address.ToString();

            switch (packetHeader.PacketType)
            {
                case "MessageSellerFind":
                    string[] splittedString = incomingObject.Split(';');
                    SellerDataBase sellerDataBase = new SellerDataBase();
                    IEnumerable<Seller> list = null;

                    if (splittedString.Count() == 1)
                    {
                        list = sellerDataBase.Search(Convert.ToInt32(splittedString[0]));
                    }
                    else if(splittedString.Count() == 2)
                    {
                        list = sellerDataBase.Search(splittedString[0], splittedString[1]);
                    }
                    
                    if(list != null)
                    {
                        NetworkComms.SendObject("MessageSellerListStart", addresse, remoteIpEndPoint.Port, "true");

                        foreach (Seller seller in list)
                        {
                            NetworkComms.SendObject("MessageSellerList", addresse, remoteIpEndPoint.Port, seller);
                        }

                    }

                    break;

                case "MessageHeartBeat":
                    NetworkComms.SendObject("MessageHeartBeatBack", addresse, remoteIpEndPoint.Port, DateTime.Now.ToShortTimeString());
                    break;
                case "MessageGetStatistik":
                    NetworkComms.SendObject("MessageStatistikListStart", addresse, remoteIpEndPoint.Port, "true");
                    StatistikDataBase statistikDataBase = new StatistikDataBase();
                    IEnumerable<Statistik> listStatistik = null;
                    listStatistik = statistikDataBase.FindAll();

                    foreach (Statistik seller in listStatistik)
                    {
                        NetworkComms.SendObject("MessageStatistikList", addresse, remoteIpEndPoint.Port, seller);
                    }

                    NetworkComms.SendObject("MessageStatistikListStart", addresse, remoteIpEndPoint.Port, "false");
                    break;
            }
        }

        private static void IncomingMessageSeller(PacketHeader packetHeader, Connection connection, Seller incomingObject)
        {
            Console.WriteLine("\nA message was received from " + connection.ToString() + " which said '" + incomingObject.SellerId + "'.");
            IPEndPoint remoteIpEndPoint = connection.ConnectionInfo.RemoteEndPoint as IPEndPoint;
            string addresse = remoteIpEndPoint.Address.ToString();
            SellerDataBase sellerDataBase = new SellerDataBase();
            
            if (incomingObject.SellerId == -1 || incomingObject.CreateNewSeller == true)
            {
                if (incomingObject.CreateNewSeller == false)
                {
                    incomingObject.SellerId = sellerDataBase.Count() + 1;
                    NetworkComms.SendObject("MessageNewSellerId", addresse, remoteIpEndPoint.Port, incomingObject.SellerId.ToString());
                }

                sellerDataBase.Upsert(incomingObject);
            }
            else
            {
                Seller findSeller = sellerDataBase.FindOne(x => x.SellerId == incomingObject.SellerId);

                if(findSeller == null)
                {
                    //no Seller with the id found send it back
                    NetworkComms.SendObject("MessageSellerIdNotFound", addresse, remoteIpEndPoint.Port, "Die Verkäufer Id konnte nicht gefunden werden!");
                    return;
                }

                findSeller.Match(incomingObject);
                sellerDataBase.Upsert(findSeller);
            }

            NetworkComms.SendObject("MessageSellerCount", addresse, remoteIpEndPoint.Port, "Anzahl Verkäufernummer: " + sellerDataBase.Count().ToString());
        }

        private static void IncomingMessagePartInformations(PacketHeader packetHeader, Connection connection, PartInformations incomingObject)
        {
            Console.WriteLine("\nA message was received from " + connection.ToString() + " which said '" + incomingObject.PartDescription + "'.");

            IPEndPoint remoteIpEndPoint = connection.ConnectionInfo.RemoteEndPoint as IPEndPoint;
            string addresse = remoteIpEndPoint.Address.ToString();
            SellerDataBase sellerDataBase = new SellerDataBase();
            PartInformationsDataBase partInformationsDataBase = new PartInformationsDataBase();
            StatistikDataBase statistikDataBase = new StatistikDataBase();

            //Seller foundedSeller = sellerDataBase.FindOne(x => x.SellerId == incomingObject.SellerId);
            Seller foundedSeller = sellerDataBase.FindOne(x => x.SaleNumbers.Contains(incomingObject.SellerId));

            
            switch (packetHeader.PacketType)
            {
                case "MessagePartInformations":
                    if (foundedSeller != null)
                    {
                        NetworkComms.SendObject("MessageSellerIsFound", addresse, remoteIpEndPoint.Port, incomingObject);
                    }
                    else
                    {
                        //TODO Send to Seller Client --> the seller id is not found in die Seller DataBase
                        NetworkComms.SendObject("MessageSellerIdFromPartNotFound", addresse, remoteIpEndPoint.Port, "Die Verkäufernummer wurde nicht gefunden...");
                    }
                    break;
                case "MessagePartInformationsConfirmed":
                    //added only date and the ip address from the sender
                    Statistik statistik = new Statistik(DateTime.Now, remoteIpEndPoint.ToString());
                    statistikDataBase.Upsert(statistik);

                    //added part to the database
                    partInformationsDataBase.Upsert(incomingObject);
                    break;
            }

        }
    }
}

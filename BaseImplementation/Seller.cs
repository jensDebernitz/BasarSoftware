using DataBase;
using NetworkCommsDotNet.DPSBase;
using Newtonsoft.Json;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CustomDataObjects
{
    [ProtoContract]
    [JsonObject(MemberSerialization.OptIn)]
    public class Seller : DataBaseObject, IExplicitlySerialize
    {
        [ProtoMember(1)]
        [JsonProperty]
        public int SellerId { get; set; }

        [ProtoMember(2)]
        [JsonProperty]
        public string SellerSureName { get; set; }
        
        [ProtoMember(3)]
        [JsonProperty]
        public string SellerGivenName { get; set; }

        [ProtoMember(4)]
        [JsonProperty]
        public string SellerStreetHouseNumber { get; set; }

        [ProtoMember(5)]
        [JsonProperty]
        public string SellerVillagePostalCode { get; set; }

        [ProtoMember(6)]
        [JsonProperty]
        public string Email { get; set; }

        [ProtoMember(7)]
        [JsonProperty]
        public bool CreateNewSeller { get; set; } = false;

        [ProtoMember(8)]
        [JsonProperty]
        public List<int> SaleNumbers { get; set; } = new List<int>();


        public Seller(  int id, 
                        string givenName, 
                        string sureName,  
                        string streetHouseNumber, 
                        string villagePostalCode, 
                        string eMail)
        {
            SellerId = id;
            SellerSureName = sureName;
            SellerGivenName = givenName;
            SellerStreetHouseNumber = streetHouseNumber;
            SellerVillagePostalCode = villagePostalCode;
            Email = eMail;
        }

        private Seller()
        {

        }

        public void Match(Seller toMatchSeller)
        {
            SellerSureName = toMatchSeller.SellerSureName;
            SellerGivenName = toMatchSeller.SellerGivenName;
            SellerStreetHouseNumber = toMatchSeller.SellerStreetHouseNumber;
            SellerVillagePostalCode = toMatchSeller.SellerVillagePostalCode;
        }

        public static void Deserialize(System.IO.Stream inputStream, out Seller result)
        {
            result = new Seller();
            result.Deserialize(inputStream);
        }

        public void Deserialize(Stream inputStream)
        {
            byte[] sourceSellerId = new byte[sizeof(int)];
            inputStream.Read(sourceSellerId, 0, sizeof(int));
            SellerId = BitConverter.ToInt32(sourceSellerId, 0);

            byte[] sourceSellerSureNameLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceSellerSureNameLengthData, 0, sizeof(int));
            byte[] sourceSellerSureName = new byte[BitConverter.ToInt32(sourceSellerSureNameLengthData, 0)];
            inputStream.Read(sourceSellerSureName, 0, sourceSellerSureName.Length);
            SellerSureName = new String(Encoding.UTF8.GetChars(sourceSellerSureName));

            byte[] sourceSellerGivenNameLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceSellerGivenNameLengthData, 0, sizeof(int));
            byte[] sourceSellerGivenName = new byte[BitConverter.ToInt32(sourceSellerGivenNameLengthData, 0)];
            inputStream.Read(sourceSellerGivenName, 0, sourceSellerGivenName.Length);
            SellerGivenName = new String(Encoding.UTF8.GetChars(sourceSellerGivenName));

            byte[] sourceSellerStreetHouseNumberLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceSellerStreetHouseNumberLengthData, 0, sizeof(int));
            byte[] sourceSellerStreetHouseNumber = new byte[BitConverter.ToInt32(sourceSellerStreetHouseNumberLengthData, 0)];
            inputStream.Read(sourceSellerStreetHouseNumber, 0, sourceSellerStreetHouseNumber.Length);
            SellerStreetHouseNumber = new String(Encoding.UTF8.GetChars(sourceSellerStreetHouseNumber));

            byte[] sourceSellerVillagePostalCodeLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceSellerVillagePostalCodeLengthData, 0, sizeof(int));
            byte[] sourceSellerVillagePostalCode = new byte[BitConverter.ToInt32(sourceSellerVillagePostalCodeLengthData, 0)];
            inputStream.Read(sourceSellerVillagePostalCode, 0, sourceSellerVillagePostalCode.Length);
            SellerVillagePostalCode = new String(Encoding.UTF8.GetChars(sourceSellerVillagePostalCode));

            byte[] sourceEmailLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceEmailLengthData, 0, sizeof(int));
            byte[] sourceEmail = new byte[BitConverter.ToInt32(sourceEmailLengthData, 0)];
            inputStream.Read(sourceEmail, 0, sourceEmail.Length);
            Email = new String(Encoding.UTF8.GetChars(sourceEmail));

            byte[] sourceCreateNewSeller = new byte[sizeof(bool)];
            inputStream.Read(sourceCreateNewSeller, 0, sizeof(bool));
            CreateNewSeller = BitConverter.ToBoolean(sourceCreateNewSeller, 0);

            byte[] sourceSaleNumbersLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceSaleNumbersLengthData, 0, sizeof(int));

            for(int i = 0; i < BitConverter.ToInt32(sourceSaleNumbersLengthData, 0); i++)
            {
                byte[] sourceSaleNumbers = new byte[sizeof(int)];

                inputStream.Read(sourceSaleNumbers, 0, sizeof(int));
                SaleNumbers.Add(BitConverter.ToInt32(sourceSaleNumbers, 0));
            }

        }

        public void Serialize(Stream outputStream)
        {
            List<byte[]> data = new List<byte[]>();

            byte[] sourceSellerId = BitConverter.GetBytes(SellerId);
            data.Add(sourceSellerId);

            byte[] sourceSellerSureName = Encoding.UTF8.GetBytes(SellerSureName ?? "");
            byte[] sourceSellerSureNameLengthData = BitConverter.GetBytes(sourceSellerSureName.Length);
            data.Add(sourceSellerSureNameLengthData);
            data.Add(sourceSellerSureName);

            byte[] sourceSellerGivenName = Encoding.UTF8.GetBytes(SellerGivenName ?? "");
            byte[] sourceSellerGivenNameLengthData = BitConverter.GetBytes(sourceSellerGivenName.Length);
            data.Add(sourceSellerGivenNameLengthData);
            data.Add(sourceSellerGivenName);

            byte[] sourceSellerStreetHouseNumber = Encoding.UTF8.GetBytes(SellerStreetHouseNumber ?? "");
            byte[] sourceSellerStreetHouseNumberLengthData = BitConverter.GetBytes(sourceSellerStreetHouseNumber.Length);
            data.Add(sourceSellerStreetHouseNumberLengthData);
            data.Add(sourceSellerStreetHouseNumber);

            byte[] sourceSellerVillagePostalCode = Encoding.UTF8.GetBytes(SellerVillagePostalCode ?? "");
            byte[] sourceSellerVillagePostalCodeLengthData = BitConverter.GetBytes(sourceSellerVillagePostalCode.Length);
            data.Add(sourceSellerVillagePostalCodeLengthData);
            data.Add(sourceSellerVillagePostalCode);

            byte[] sourceEmail = Encoding.UTF8.GetBytes(Email ?? "");
            byte[] sourceEmailLengthData = BitConverter.GetBytes(sourceEmail.Length);
            data.Add(sourceEmailLengthData);
            data.Add(sourceEmail);

            byte[] sourceCreateNewSeller = BitConverter.GetBytes(CreateNewSeller);
            data.Add(sourceCreateNewSeller);

            byte[] bytesAsInts = Array.ConvertAll(SaleNumbers.ToArray(), c => (byte)c);
            data.Add(BitConverter.GetBytes(bytesAsInts.Length));

            foreach (int i in SaleNumbers)
            {
                data.Add(BitConverter.GetBytes(i));
            }
            

            foreach (byte[] datum in data)
            {
                outputStream.Write(datum, 0, datum.Length);
            }

        }
    }

    public class SellerDataBase : BaseImplementation<Seller>
    {
        public SellerDataBase() : base()
        {

        }

        public IEnumerable<Seller> Search(int sellerId)
        {
            return base.Find(x => x.SellerId == sellerId);
        }

        public IEnumerable<Seller> Search(string givenName, string sureName)
        {
            if (String.IsNullOrEmpty(givenName) == false && String.IsNullOrEmpty(sureName) == true)
            {
                return base.Find(x => x.SellerGivenName.ToLower() == givenName.ToLower());
            }
            else if (String.IsNullOrEmpty(givenName) == true && String.IsNullOrEmpty(sureName) == false)
            {
                return base.Find(x => x.SellerSureName.ToLower() == sureName.ToLower());
            }
            else if (String.IsNullOrEmpty(givenName) == false && String.IsNullOrEmpty(sureName) == false)
            {
                return base.Find(x => x.SellerSureName.ToLower() == sureName.ToLower() && x.SellerGivenName.ToLower() == givenName.ToLower());
            }

            return null;
        }
    }
}

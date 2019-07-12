using DataBase;
using NetworkCommsDotNet.DPSBase;
using Newtonsoft.Json;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CustomDataObjects
{
    [ProtoContract]
    [JsonObject(MemberSerialization.OptIn)]
    public class PartInformations : DataBaseObject, IExplicitlySerialize
    {
        [ProtoMember(1)]
        [JsonProperty]
        public int PartNumber { get; set; }
        [ProtoMember(2)]
        [JsonProperty]
        public string PartDescription { get; set; }
        [ProtoMember(3)]
        [JsonProperty]
        public double PartPrice { get; set; }
        [ProtoMember(4)]
        [JsonProperty]
        public int SellerId { get; set; }


        public PartInformations(int partNumber, string partDescription, double partPrice, int sellerId)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            PartPrice = partPrice;
            SellerId = sellerId;
        }

        private PartInformations()
        {

        }

        public static void Deserialize(System.IO.Stream inputStream, out PartInformations result)
        {
            result = new PartInformations();
            result.Deserialize(inputStream);
        }

        public void Deserialize(Stream inputStream)
        {
            byte[] sourcePartNumber = new byte[sizeof(int)];
            inputStream.Read(sourcePartNumber, 0, sizeof(int));
            PartNumber = BitConverter.ToInt32(sourcePartNumber, 0);

            byte[] sourcePartDescriptionLengthData = new byte[sizeof(int)];
            inputStream.Read(sourcePartDescriptionLengthData, 0, sizeof(int));
            byte[] sourcePartDescription = new byte[BitConverter.ToInt32(sourcePartDescriptionLengthData, 0)];
            inputStream.Read(sourcePartDescription, 0, sourcePartDescription.Length);
            PartDescription = new String(Encoding.UTF8.GetChars(sourcePartDescription));

            byte[] sourcePartPrice = new byte[sizeof(double)];
            inputStream.Read(sourcePartPrice, 0, sizeof(double));
            PartPrice = BitConverter.ToDouble(sourcePartPrice, 0);

            byte[] sourceSellerId = new byte[sizeof(int)];
            inputStream.Read(sourceSellerId, 0, sizeof(int));
            SellerId = BitConverter.ToInt32(sourceSellerId, 0);
        }

        public void Serialize(Stream outputStream)
        {
            List<byte[]> data = new List<byte[]>();

            byte[] sourcePartNumber = BitConverter.GetBytes(PartNumber);
            data.Add(sourcePartNumber);

            byte[] sourcePartDescription = Encoding.UTF8.GetBytes(PartDescription);
            byte[] sourcePartDescriptionLengthData = BitConverter.GetBytes(sourcePartDescription.Length);
            data.Add(sourcePartDescriptionLengthData);
            data.Add(sourcePartDescription);

            byte[] sourcePartPrice = BitConverter.GetBytes(PartPrice);
            data.Add(sourcePartPrice);

            byte[] sourceSellerId = BitConverter.GetBytes(SellerId);
            data.Add(sourceSellerId);

            foreach (byte[] datum in data)
            {
                outputStream.Write(datum, 0, datum.Length);
            }
        }
    }

    public class PartInformationsDataBase : BaseImplementation<PartInformations>
    {
        public PartInformationsDataBase() : base()
        {

        }
    }
}

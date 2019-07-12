using DataBase;
using NetworkCommsDotNet.DPSBase;
using Newtonsoft.Json;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataObjects
{
    [ProtoContract]
    [JsonObject(MemberSerialization.OptIn)]
    public class Statistik : DataBaseObject, IExplicitlySerialize
    {
        [ProtoMember(1)]
        [JsonProperty]
        public DateTime SellDateTime { get; set; }
        [ProtoMember(2)]
        [JsonProperty]
        public string CashRegister { get; set; }


        public Statistik(DateTime dateTime, string chashRegister)
        {
            SellDateTime = dateTime;
            CashRegister = chashRegister;
        }

        private Statistik()
        {

        }

        public static void Deserialize(System.IO.Stream inputStream, out Statistik result)
        {
            result = new Statistik();
            result.Deserialize(inputStream);
        }

        public void Deserialize(Stream inputStream)
        {
            byte[] sourceSellDateTimeLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceSellDateTimeLengthData, 0, sizeof(int));
            byte[] sourceSellDateTime = new byte[BitConverter.ToInt32(sourceSellDateTimeLengthData, 0)];
            inputStream.Read(sourceSellDateTime, 0, sourceSellDateTime.Length);
            SellDateTime = Convert.ToDateTime(new String(Encoding.UTF8.GetChars(sourceSellDateTime)));

            byte[] sourceCashRegisterLengthData = new byte[sizeof(int)];
            inputStream.Read(sourceCashRegisterLengthData, 0, sizeof(int));
            byte[] sourceCashRegister = new byte[BitConverter.ToInt32(sourceCashRegisterLengthData, 0)];
            inputStream.Read(sourceCashRegister, 0, sourceCashRegister.Length);
            CashRegister = new String(Encoding.UTF8.GetChars(sourceCashRegister));

        }

        public void Serialize(Stream outputStream)
        {
            List<byte[]> data = new List<byte[]>();

            byte[] sourceSellDateTime = Encoding.UTF8.GetBytes(SellDateTime.ToString());
            byte[] sourceSellDateTimeLengthData = BitConverter.GetBytes(sourceSellDateTime.Length);
            data.Add(sourceSellDateTimeLengthData);
            data.Add(sourceSellDateTime);


            byte[] sourceCashRegister = Encoding.UTF8.GetBytes(CashRegister);
            byte[] sourceCashRegisterLengthData = BitConverter.GetBytes(sourceCashRegister.Length);
            data.Add(sourceCashRegisterLengthData);
            data.Add(sourceCashRegister);


            foreach (byte[] datum in data)
            {
                outputStream.Write(datum, 0, datum.Length);
            }

        }
    }



    public class StatistikDataBase : BaseImplementation<Statistik>
    {
        public StatistikDataBase() : base()
        {

        }
    }
}

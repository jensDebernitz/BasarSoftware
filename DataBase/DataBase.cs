using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class DataBase
    {
        static private readonly string PATH_DATABASE_FILE = "basar.db";

        private static LiteDatabase mLiteDataBase = null;

        public static void Init(string path)
        {
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            string filePath= path + PATH_DATABASE_FILE;

            mLiteDataBase = new LiteDatabase(filePath);
        }

        public static LiteDatabase GetDataBase()
        {
            return mLiteDataBase;
        }
            
    }
}

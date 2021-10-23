using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "Hello World!";
            Encoding enc = Encoding.UTF8;
            byte[] bt = enc.GetBytes(ss);
            using (MemoryStream ms = new MemoryStream(bt))
            {
                printStream(enc, ms);
                using (FileStream fs = File.Create("1.txt"))
                {
                    writeStream(ms, fs);
                }
            }

            using (FileStream fs = File.OpenRead("1.txt"))
            {
                printStream(enc, fs);
                using (StreamReader sr = new StreamReader(fs, enc))
                {
                    while (!sr.EndOfStream)
                    {
                        // int iCh = sr.Read();
                        string sText = sr.ReadLine();
                    }
                }
            }
        }

        private static void writeStream(Stream fsIn, Stream fsOut)
        {
            fsIn.Seek(0, SeekOrigin.Begin);
            while (fsIn.Length - 1 >= fsIn.Position)
            {
                byte[] btFrom = new byte[1];
                fsIn.Read(btFrom, 0, 1);
                if (btFrom[0] != 71)
                {
                    fsOut.Write(btFrom);
                }
            }
        }

        private static void printStream(Encoding enc, Stream ms)
        {
            int iCount = 0;
            ms.Seek(0, SeekOrigin.Begin);
            while (ms.Length - 1 >= ms.Position)
            {
                byte[] btFrom = new byte[1];
                ms.Read(btFrom, 0, 1);
                if (btFrom[0] == 71)
                {
                    iCount++;
                    if (iCount > 3)
                    {
                        return;
                    }
                }
                Console.Write(enc.GetString(btFrom));
            }
        }
    }
}

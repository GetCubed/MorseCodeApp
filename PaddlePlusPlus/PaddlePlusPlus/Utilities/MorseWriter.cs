using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaddlePlusPlus.Utilities
{
    public static class MorseWriter
    {
        public static void write(string text)
        {
            string path = @"D:\Users\GetCubed\MorseCode.txt";
            File.Create(path);


            //MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(path));

            //StreamWriter writer = new StreamWriter(memoryStream);
            //writer.Write(text);
            //writer.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBinaryStream();
            WriteTextStream();
        }

        private static void WriteBinaryStream()
        {
            var fileName = "mybinaryfile.txt";

            var fs = File.Open(fileName, FileMode.OpenOrCreate);

            var binaryWriter = new BinaryWriter(fs);

            var binaryBuffer = Encoding.UTF8.GetBytes("Hello there!");

            binaryWriter.Write(binaryBuffer);

            binaryWriter.Close();
        }

        static void WriteTextStream()
        {
            var fileName = "mytextfile.txt";

            var fs = File.Open(fileName, FileMode.OpenOrCreate);

            var textWriter = new StreamWriter(fs);

            var textBuffer = "This is text";

            textWriter.Write(textBuffer);

            textWriter.Close();
        }
    }
}

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
            FileCopier("lorem.txt", "lorem-copy.txt");
            FileCopierBinary("image.jpg", "image-copy.jpg");
        }

        static void FileCopier(string inputFileName, string outputFileName)
        {
            using (var inputFileStream = new FileStream(inputFileName, FileMode.Open))
            using (var inputStreamReader = new StreamReader(inputFileStream))
            using (var outputFileStream = new FileStream(outputFileName, FileMode.Create))
            using (var outputStreamWriter = new StreamWriter(outputFileStream))
            {
                while (!inputStreamReader.EndOfStream)
                {
                    var line = inputStreamReader.ReadLine();

                    if (inputStreamReader.EndOfStream)
                    {
                        outputStreamWriter.Write(line);
                    }
                    else
                    {
                        outputStreamWriter.WriteLine(line);
                    }
                }
            }
        }

        static void FileCopierShorthand(string inputFileName, string outputFileName)
        {
            using (var inputStreamReader = new StreamReader(inputFileName))    
            using (var outputStreamWriter = new StreamWriter(outputFileName))
            {
                while (!inputStreamReader.EndOfStream)
                {
                    var line = inputStreamReader.ReadLine();

                    if (inputStreamReader.EndOfStream)
                    {
                        outputStreamWriter.Write(line);
                    }
                    else
                    {
                        outputStreamWriter.WriteLine(line);
                    }
                    
                }
            }
        }

        static void FileCopierBinary(string inputFileName, string outputFileName)
        {
            using (var inputStream = File.Open(inputFileName, FileMode.Open, FileAccess.Read))
            using (var outputStream = File.Create(outputFileName))
            {
                const int EOF = -1;

                int byteRead = inputStream.ReadByte();  //  if the file is empty, -1 is returned. therefore int.

                while (byteRead != EOF)
                {
                    outputStream.WriteByte((byte) byteRead);
                    byteRead = inputStream.ReadByte();
                }
            }
        }
    }
}

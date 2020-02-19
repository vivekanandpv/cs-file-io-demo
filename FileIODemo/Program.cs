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
            using (var outputStream = new StreamWriter("sample.txt"))
            {
                var userInput = Console.ReadLine();

                while (userInput.ToLower() != "q")
                {
                    outputStream.WriteLine(userInput);
                    userInput = Console.ReadLine();
                }
            }
        }

    }
}

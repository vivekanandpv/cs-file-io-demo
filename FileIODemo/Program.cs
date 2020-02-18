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
            var fileName = "myfile.txt";

            var content = "Here is the content to be written";

            File.WriteAllText(fileName, content);

            File.AppendAllText(fileName, "These lines are appended");

            File.Copy("image.jpg", "copy_image.jpg");
        }
    }
}

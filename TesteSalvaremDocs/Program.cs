using System;
using System.IO;
using System.Threading.Tasks;

namespace TesteSalvaremDocs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sr = new StreamWriter(@"C:\Users\USERNAME\Desktop\FOLDERNAME\FileSmth.txt", true);
            Console.WriteLine("Write something down: ");
            string smth = Console.ReadLine();
            sr.WriteLine(smth);
            sr.Close();
            Console.ReadLine();
        }
    }
}

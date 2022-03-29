using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upisi Ime: ");
            string ime = Console.ReadLine();

            string datoteka = "Ime.txt";

            if (File.Exists(datoteka))
            {
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }
                File.Copy(datoteka, @"backup\ime_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss" + ".txt"));


                File.Delete(datoteka);
            }

            File.WriteAllText(datoteka, ime);
            
            Console.ReadKey();


        }
    }
}

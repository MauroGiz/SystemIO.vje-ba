using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GizdulićMauroSIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();

            if(Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach(string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }

                string putanjaPoddirektorija = putanja + "\\TEST";

                if(!Directory.Exists(putanjaPoddirektorija))
                {
                    Directory.CreateDirectory(putanjaPoddirektorija);
                }

                Console.WriteLine("Poddirektoriji: ");
                foreach (string poddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }

                Directory.Delete(putanjaPoddirektorija);

                Console.WriteLine("Nakon brisanja direktorija TEST:");

                foreach (string poddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }
            }
            else
            {
                Console.WriteLine("Putanja ne postoji na računalu!");
            }
            Console.ReadKey();
        }
    }
}

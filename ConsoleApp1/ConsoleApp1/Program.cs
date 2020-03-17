using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numerovoti=0;
            double votoTotale=0;
            double voto;
            Console.WriteLine("Inserisci un numero di voti");
            numerovoti = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numerovoti; i++)
            {
                Console.WriteLine("inserisci un voto");
                voto = Convert.ToDouble(Console.ReadLine());
                votoTotale = votoTotale+voto;
            }
            double mediaVoto = votoTotale / numerovoti;
            Console.WriteLine("La media e' {0}", mediaVoto);
            Console.ReadLine();
           
        }
    }
}

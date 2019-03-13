using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            // wczytanie ilosci liczb
            Console.WriteLine("Podaj ilosc liczb: ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            // wczytanie liczb
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " liczbe: ");
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int wynik = 0;
            // dla kazdej z podanych liczb wykorzystany jest operator bitowy OR
            foreach (int x in tab)
            {
                wynik |= x;
            };

            for (int i = 0; i < 32; i++)
            {
                // przesuniecie bitowe w lewo dla kazdego bitu
                int potega = 1 << i;
                if ((wynik & potega) != 0)
                {
                    Console.WriteLine(potega);
                }             
            }
           
            Console.ReadKey();
        }
    }
}

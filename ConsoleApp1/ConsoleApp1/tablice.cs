using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class tablice
    {
        public void Powitanie()

        {
            Console.WriteLine("witaj w pliku tablice!");
        }
        public int[] Stworz_tablice()
        {
            Console.WriteLine("ile elemntow ma miec tqblica");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("podaj kolejhy elemnt tabliocy");
                ints[i] = int.Parse(Console.ReadLine());    
            }
            Console.WriteLine();
            return ints;   
        }
        public void wyswietl_tablice(int[] tab)
        {
            Console.WriteLine("elementy tabliocy:");
            foreach (int i in tab)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }

}

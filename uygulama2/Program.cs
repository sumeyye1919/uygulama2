
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama2
{
    internal class Program
    {
        static bool NumaraVarMi(List<string> liste, string aranan)
        {
            foreach (string numara in liste)
            {
                if (numara == aranan)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            List<string> numaralar = new List<string>
            {
                "111",
                "222",
                "333",
                "444"
            };

            Console.WriteLine("İlk eleman (111): " +
                NumaraVarMi(numaralar, "111"));

            Console.WriteLine("Son eleman (444): " +
                NumaraVarMi(numaralar, "444"));

            Console.WriteLine("Olmayan numara (555): " +
                NumaraVarMi(numaralar, "555"));

            List<string> bosListe = new List<string>();

            Console.WriteLine("Boş liste: " +
                NumaraVarMi(bosListe, "111"));
        }
    }
}
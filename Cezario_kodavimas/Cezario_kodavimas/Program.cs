using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezario_kodavimas
{
    class Program
    {
        public struct CezarioKodas
        {
            public string psw;
            public string EncodeText(string tex)
            {
                string result = "";
                int keyIndex = 0;
                foreach (var symbol in tex)
                {
                    result += (char)((byte)symbol + (byte)psw[keyIndex]);
                    if (keyIndex == psw.Length - 1)
                    {
                        keyIndex = 0;
                    }
                    else
                    {
                        keyIndex++;
                    }
                }
                return result;
            }

            public string DecodeText(string tex)
            {
                string result = "";
                int keyIndex = 0;
                foreach (var symbol in tex)
                {
                    result += (char)((byte)symbol - (byte)psw[keyIndex]);
                    if (keyIndex == psw.Length - 1)
                    {
                        keyIndex = 0;
                    }
                    else
                    {
                        keyIndex++;
                    }
                }
                return result;
            }

        }
        static void Main(string[] args)
        {
            CezarioKodas kodavimas = new CezarioKodas();

            Console.WriteLine("Iveskite slaptazodi:");
            string slpt = Console.ReadLine();
            kodavimas.psw = slpt;

            Console.WriteLine("Uzkoduotas slaptazodis: {0}", kodavimas.EncodeText(slpt));
            string kodSl = kodavimas.EncodeText(slpt);
            Console.WriteLine("Atkoduotas slaptazodis: {0}", kodavimas.DecodeText(kodSl));
            Console.ReadLine();
        }
    }
}

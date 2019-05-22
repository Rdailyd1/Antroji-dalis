using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM7_3ManoIslaidos
{
    class Program
    {
        public struct ManoIslaidos
        {
            public decimal maistas;
            public decimal buitis;
            public decimal mokesciai;
            public decimal laisvalaikis;
            public decimal saviugda;
            public decimal kita;
            public decimal isleistaPinigu()
            {
                decimal suma = maistas + buitis + mokesciai + laisvalaikis + saviugda + kita;
                return suma;
            }
            public decimal ProcentaiPagalKategorija(int kategorija)
            {
                decimal procentas = 0;
                switch (kategorija)
                {
                    case 1:
                        procentas = maistas * 100 / isleistaPinigu();
                        break;
                    case 2:
                        procentas = buitis * 100 / isleistaPinigu();
                        break;
                    case 3:
                        procentas = mokesciai * 100 / isleistaPinigu();
                        break;
                    case 4:
                        procentas = laisvalaikis * 100 / isleistaPinigu();
                        break;
                    case 5:
                        procentas = saviugda * 100 / isleistaPinigu();
                        break;
                    case 6:
                        procentas = kita * 100 / isleistaPinigu();
                        break;
                    case 7:
                        procentas = (maistas+buitis+mokesciai+laisvalaikis+saviugda+kita) * 100 / isleistaPinigu();
                        break;
                }


                return procentas;
            }
        }
        static void Main(string[] args)
        {
            ManoIslaidos mano_islaidos = new ManoIslaidos();
            mano_islaidos.maistas = 450m;
            mano_islaidos.buitis = 680m;
            mano_islaidos.mokesciai = 300m;
            mano_islaidos.laisvalaikis = 300m;
            mano_islaidos.saviugda = 200m;
            mano_islaidos.kita = 200m;

            Console.WriteLine("Mano išlaidos viso: {0} eur", mano_islaidos.isleistaPinigu());
            Console.WriteLine("Maistui: {0} %", Math.Round(mano_islaidos.ProcentaiPagalKategorija(1),2));
            Console.WriteLine("Buiciai: {0} %", Math.Round(mano_islaidos.ProcentaiPagalKategorija(2), 2));
            Console.WriteLine("Mokesciams: {0} %", Math.Round(mano_islaidos.ProcentaiPagalKategorija(3), 2));
            Console.WriteLine("Laisvalaikiui: {0} %", Math.Round(mano_islaidos.ProcentaiPagalKategorija(4), 2));
            Console.WriteLine("Saviugdai: {0} %", Math.Round(mano_islaidos.ProcentaiPagalKategorija(5), 2));
            Console.WriteLine("Kitos islaidos: {0} %", Math.Round(mano_islaidos.ProcentaiPagalKategorija(6), 2));
            Console.WriteLine("Viso: {0} %", Math.Round(mano_islaidos.ProcentaiPagalKategorija(7), 2));
            Console.ReadLine();
        }
    }
}

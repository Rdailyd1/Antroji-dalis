using System;

namespace Pirkinys
{
    public struct pirkinys
    {
        private string _PrekesPavadinimas;
        private int _Kiekis;
        private decimal _KainaVieneto;

        public string PrekesPavadinimas
        {
            get
            {
                return _PrekesPavadinimas;
            }
            set
            {
                _PrekesPavadinimas = value;
            }
        }
        public int Kiekis
        {
            get
            {
                return _Kiekis;
            }
            set
            {
                _Kiekis = value;
            }
        }
        public decimal KainaVieneto
        {
            get
            {
                return _KainaVieneto;
            }
            set
            {
                _KainaVieneto = value;
            }
        }
        public decimal KainaViso
        {
            get
            {
                return _KainaVieneto * _Kiekis;
            }
        }

        public pirkinys(string pavadinimas, int kiekis, decimal kaina)
        {
            _PrekesPavadinimas = pavadinimas;
            _Kiekis = kiekis;
            _KainaVieneto = kaina;
        }

    }
}

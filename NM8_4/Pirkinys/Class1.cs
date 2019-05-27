using System;

namespace Pirkinys
{
    public struct pirkinys
    {
        public string _PrekėsPavadinimas;
        public int _Kiekis;
        public decimal _KainaVieneto;
        public decimal _KainaViso;

        public string PrekesPaadinimas
        {
            get
            {
                return _PrekėsPavadinimas;
            }
            private set
            {
                _PrekėsPavadinimas = value;
            }
        }
        public int Kiekis
        {
            get
            {
                return _Kiekis;
            }
            private set
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
            private set
            {
                _KainaVieneto = value;
            }
        }
        public decimal KainaViso
        {
            get
            {
                _KainaViso = _KainaVieneto * _Kiekis;
                return _KainaViso;
            }
        }

    }
}

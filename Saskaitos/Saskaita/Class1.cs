using System;

namespace Saskaita
{
    public struct saskaita
    {
        private string _gavejas;
        private string _siuntejas;
        private int _moketiViso;
       
        public string Gavejas
        {
            get
            {
                return _gavejas;
            }
            private set
            {
                _gavejas = value;
            }
        }

        public string Siuntejas
        {
            get
            {
                return _siuntejas;
            }
            private set
            {
                _siuntejas = value;
            }
        }

        public int MoketiViso
        {
            get
            {
                return _moketiViso;
            }
            private set
            {
                _moketiViso = value;
            }
        }

        public string SaskaitosNumeris
        {
            get
            {
                return string.Format("NR {0}_{1}_{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
        }

        public saskaita(string gavejas, string siuntejas, int moketiviso)
        {
            _siuntejas = siuntejas;
            _gavejas = gavejas;
            _moketiViso = moketiviso;
        }

    }
}

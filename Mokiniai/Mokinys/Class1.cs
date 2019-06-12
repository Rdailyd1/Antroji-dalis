using System;
using System.Collections.Generic;

namespace Mokinys
{
    public class MokinysCs
    {
        public int ID { get; private set; }
        public string vardas { get; private set; }
        public List<int> pazymiuSarasas { get; set; }
        public MokinysCs()
        {
           var pazimiuSarasas = new List<int>();
        }
    }
}

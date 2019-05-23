using System;
using System.Collections.Generic;

namespace MokinysStruct
{
    public struct Mokinys
    {
        public List<int> trimestras1;
        public List<int> trimestras2;
        public List<int> trimestras3;
        public List<int> bendras;
        
        public int PirmojoTrimestroVidurkis()
        {
            int sum=0;
            int vid=0;

            foreach (int elementas in trimestras1)
            {
                sum += elementas;
            }
            vid = sum / trimestras1.Count;
                return vid;
        }
        public int AntrojoTrimestroVidurkis()
        {
            int sum = 0;
            int vid = 0;

            foreach (int elementas in trimestras2)
            {
                sum += elementas;
            }
            vid = sum / trimestras2.Count;
            return vid;
        }
        public int TrecioTrimestroVidurkis()
        {
            int sum = 0;
            int vid = 0;

            foreach (int elementas in trimestras3)
            {
                sum += elementas;
            }
            vid = sum / trimestras3.Count;
            return vid;
        }
        public int MetinisPazymys()
        {
            int sum = 0;
            var bendras = new List<int>();
            bendras.AddRange(trimestras1);
            bendras.AddRange(trimestras2);
            bendras.AddRange(trimestras3);
            foreach (int elementas in bendras)
            {
                sum += elementas;
            }
            return sum;
        }
    }
}

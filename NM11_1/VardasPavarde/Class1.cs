using System;
namespace VardasPavarde
{
    public class VardasPavarde_cs
    {
        private string _vardas { get; set; }
        private string _pavarde { get; set; }
        public DateTime _GimMetai { get; private set; } 
        public string Vardas(string vardas)
        {
            _vardas = vardas;
            {
                return _vardas;
            }
        }
        public string Pavarde(string pavarde)
        {
            _pavarde = pavarde;
            {
                return _pavarde;
            }
        }
        public DateTime GimMetai(DateTime gimMetai)
        {
            _GimMetai = gimMetai;
            {
                return _GimMetai;
            }
        }
        public int GetAge()
        {
            int age = Convert.ToInt16((DateTime.Now -_GimMetai).TotalDays/ 365);
            return age;
        }
    }
       
}


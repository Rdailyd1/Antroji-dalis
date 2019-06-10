using System;
namespace VardasPavarde
{
    public class VardasPavarde_cs
    {
        private string _vardas { get; set; }
        private string _pavarde { get; set; }
        public DateTime _GimMetai { get; set; } 
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
            int amzius = Convert.ToInt16((DateTime.Now -_GimMetai).TotalDays/ 365);
            return amzius;
        }
        public bool Validate()
        {
            var isValid = true;
            if (_GimMetai.Date >= DateTime.Now.Date)
            {
                isValid = false;
            }
            return isValid;
        }
    }
       
}


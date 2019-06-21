using System;
using System.Collections.Generic;
using System.Text;

namespace HumanControl
{
    public class Event
    {
        public int Id { get; set; }
        public int HumanId { get; set; }
        public int GateId { get; set;}
        public DateTime Date { get; set; }
        public bool pass { get; set; }
    }
}

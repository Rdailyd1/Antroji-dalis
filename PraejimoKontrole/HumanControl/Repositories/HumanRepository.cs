using System;
using System.Collections.Generic;
using System.Text;

namespace HumanControl.Repositories
{
    public class HumanRepository
    {
        private List<Human> zmones = new List<Human>();
        public HumanRepository()
        {
            zmones.Add(new Human() {Id = 1, Name = "Jonas", Surname = "Jonaitis", GateIdRights = new List<int>() {1} });
            zmones.Add(new Human() { Id = 2, Name = "Petras", Surname = "Petraitis", GateIdRights = new List<int>() { 2,3 } });
            zmones.Add(new Human() { Id = 2, Name = "Asta", Surname = "Aistida", GateIdRights = new List<int>() { 3 } });
        }

        public List<Human> Retrieve()
        {
            return zmones;
        }
        public  Human Retrieve(int id)
        {
            foreach(var human in zmones)
            {
                if(human.Id == id)
                {
                    return human;
                }
                
            }
            return null;
        }
    }
}

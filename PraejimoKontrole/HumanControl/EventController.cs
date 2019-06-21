using System;
using System.Collections.Generic;
using System.Text;
using HumanControl;
using HumanControl.Repositories;

namespace HumanControl
{
    public class EventController
    {
       public List<Event> _events = new List<Event>();


      public bool TryPass (int humanId, int gateId)
      {
        Event ivykis = new Event();
        ivykis.HumanId = humanId;
        ivykis.GateId = gateId;
        ivykis.Date = DateTime.Now;
        bool hasRight = false;
        Human zmogus = new HumanRepository().Retrieve(humanId);
        foreach (var oneRight in zmogus.GateIdRights)
        {
            if(oneRight == gateId)
            {
                hasRight = true;
            }
        }
        ivykis.pass = hasRight;
        _events.Add(ivykis);
        return hasRight;
      }

    }
}

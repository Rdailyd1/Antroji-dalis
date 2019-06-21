using HumanControl.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HumanControl
{
    public class ReportGenerator
    {
        private List<Event> _ivykiai;
        private HumanRepository _humanRepository;
        private GateRepository _gateRepository;
        public ReportGenerator()
        {

        }
        public ReportGenerator(List<Event> ivykiai, HumanRepository humanRepository, GateRepository gateRepository)
        {
            _ivykiai = ivykiai;
            _humanRepository = humanRepository;
            _gateRepository = gateRepository;
        }
        List<ReportEvents> GenerateTotalEvents()
        {
            List<ReportEvents> report = new List<ReportEvents>(); 
            foreach (var ivykis  in _ivykiai)
	        {
                ReportEvents reportEvent = new ReportEvents();
                reportEvent.HumanName = _humanRepository.Retrieve(ivykis.HumanId).Name;
                reportEvent.Gate = _gateRepository.Retrieve().Where(x=>x.Id == ivykis.GateId).FirstOrDefault().Code;
                reportEvent.Date = ivykis.Date;
                //reportEvent.
	        }
            return null;
        }
    }
   
}

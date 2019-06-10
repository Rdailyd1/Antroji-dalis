using System;
using System.Collections.Generic;
using System.Text;
using IAC;
using System.Linq;

namespace LektuvuRegistravimasBL
{
    public class AircraftModelRepository
    {
        private List<AircraftModel> aicraftModels = new List<AircraftModel>();
        public List<AircraftModel> Retrieve()
        {
            return aicraftModels;
        }
        public AircraftModel Retrieve(int id)
        {
            return aicraftModels.Where(x => x.Id == id).FirstOrDefault();
        }
        public AircraftModelRepository()
        {
            aicraftModels.Add(new AircraftModel(3, "B737-300", "BOEING 737-300"));
            aicraftModels.Add(new AircraftModel(4, "B737-400", "BOEING 737-400"));
            aicraftModels.Add(new AircraftModel(5, "B737-500", "BOEING 737-500"));
            aicraftModels.Add(new AircraftModel(6, "B737-700", "BOEING 737-700 "));
            aicraftModels.Add(new AircraftModel(7, "B737-800", "BOEING 737-800"));
            aicraftModels.Add(new AircraftModel(1, "A320", "AIRBUS A320"));
            aicraftModels.Add(new AircraftModel(8, "A321", "AIRBUS A321"));
            aicraftModels.Add(new AircraftModel(9, "CRJ200", "Bombardier CRJ200"));
            aicraftModels.Add(new AircraftModel(10, "ATR42-300", "ATR 42-300"));
            aicraftModels.Add(new AircraftModel(11, "ATR72-200", "ATR 72-200"));

        }
    }
}

using System;

namespace FarmLandAccountingUWP.Models
{
    public class LeasesModel
    {
        public int ID { get; set; }
        public string ContractName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int FarmID { get; set; }
        public int LandPlotID { get; set; }
    }
}

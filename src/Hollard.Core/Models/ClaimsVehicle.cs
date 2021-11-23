using Newtonsoft.Json;

namespace CluedIn.Crawling.Hollard.Core.Models
{
    public class ClaimsVehicle : ClaimsBase
    {
        public string VehicleID { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string GlassCode { get; set; }
        public string Description { get; set; }
        public string NVICCode { get; set; }
        public string RegistrationNumber { get; set; }
        public string State { get; set; }
        public string SumInsuredType { get; set; }
        public string FinancialStatus { get; set; }
        public string ParkingAddress { get; set; }
        public string Usage { get; set; }
        public string HailDamage { get; set; }
        public string VehicleSumInsured { get; set; }
        public string ModificationCover { get; set; }
        public string NonStandardAccessory { get; set; }
    }
}

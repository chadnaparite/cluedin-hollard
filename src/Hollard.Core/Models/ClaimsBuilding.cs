using Newtonsoft.Json;

namespace CluedIn.Crawling.Hollard.Core.Models
{
    public class ClaimsBuilding : ClaimsBase
    {
        public string PropertyID { get; set; }
        public string BuildingSumInsured { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StateName { get; set; }
        public string AlarmSecurity { get; set; }
        public string ExternallyAccessDoor { get; set; }
        public string ExternallyAccessWindow { get; set; }
        public string Interestedparties { get; set; }
        public string NumberOfLevels { get; set; }
        public string OccupancyType { get; set; }
        public string Quality { get; set; }
        public string RoofConstruction { get; set; }
        public string WallConstruction { get; set; }
        public string YearBuild { get; set; }
    }
}

using Newtonsoft.Json;

namespace CluedIn.Crawling.Hollard.Core.Models
{
    public class ClaimsDriver : ClaimsBase
    {
        public string DriverID { get; set; }
        public string VehicleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string DateLicensed { get; set; }
        public string CriminalConviction { get; set; }
        public string SuspensionStatus { get; set; }

        public string FullName => string.Join(' ', FirstName, LastName);
    }
}

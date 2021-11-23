using Newtonsoft.Json;

namespace CluedIn.Crawling.Hollard.Core.Models
{
    public class ClaimsInsured : ClaimsBase
    {
        public string PartyKey { get; set; }
        public string Phone { get; set; }
        public string InsuranceDeclinePast { get; set; }
        public string FullName { get; set; }
        public string Birthdate { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StateName { get; set; }
    }
}

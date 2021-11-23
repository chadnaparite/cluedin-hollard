using Newtonsoft.Json;

namespace CluedIn.Crawling.Hollard.Core.Models
{
    public class ClaimsBroker : ClaimsBase
    {
        public string PartyKey { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string BrokerCode { get; set; }
        public string BrokerUAGCode { get; set; }
    }
}

using Newtonsoft.Json;

namespace CluedIn.Crawling.Hollard.Core.Models
{
    public class ClaimsPolicy : ClaimsBase
    {
        public string PolicyNumber { get; set; }
        public string PaymentPlan { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Brand { get; set; }
        public string Product { get; set; }
        public string PolicySourcePlatform { get; set; }
        public string PolicyType { get; set; }
        public string UnderWritingCompany { get; set; }
    }
}

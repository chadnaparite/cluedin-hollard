using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace CluedIn.Crawling.Hollard.Vocabularies
{
    public class  ClaimsPolicyVocabulary : SimpleVocabulary
    {
        public  ClaimsPolicyVocabulary()
        {
            VocabularyName = "Hollard ClaimsPolicy"; 
            KeyPrefix      = "hollard.claimspolicy"; 
            KeySeparator   = ".";
            Grouping       = HollardEntities.ClaimsPolicy; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Hollard ClaimsPolicy Details", group =>
            {
                PolicyKey = group.Add(new VocabularyKey("PolicyKey", "Policy Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadDate = group.Add(new VocabularyKey("LoadDate", "Load Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyNumber = group.Add(new VocabularyKey("PolicyNumber", "Policy Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentPlan = group.Add(new VocabularyKey("PaymentPlan", "Payment Plan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey("EffectiveDate", "Effective Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey("ExpirationDate", "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Brand = group.Add(new VocabularyKey("Brand", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Product = group.Add(new VocabularyKey("Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicySourcePlatform = group.Add(new VocabularyKey("PolicySourcePlatform", "Policy Source Platform", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey("PolicyType", "Policy Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnderWritingCompany = group.Add(new VocabularyKey("UnderWritingCompany", "Under Writing Company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey PolicyKey { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LoadDate { get; private set; }
        public VocabularyKey PolicyNumber { get; private set; }
        public VocabularyKey PaymentPlan { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey Brand { get; private set; }
        public VocabularyKey Product { get; private set; }
        public VocabularyKey PolicySourcePlatform { get; private set; }
        public VocabularyKey PolicyType { get; private set; }
        public VocabularyKey UnderWritingCompany { get; private set; }
    }
}

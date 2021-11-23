using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace CluedIn.Crawling.Hollard.Vocabularies
{
    public class  ClaimsBrokerVocabulary : SimpleVocabulary
    {
        public  ClaimsBrokerVocabulary()
        {
            VocabularyName = "Hollard ClaimsBroker"; 
            KeyPrefix      = "hollard.claimsbroker"; 
            KeySeparator   = ".";
            Grouping       = HollardEntities.ClaimsBroker; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Hollard ClaimsBroker Details", group =>
            {
                PolicyKey = group.Add(new VocabularyKey("PolicyKey", "Policy Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadDate = group.Add(new VocabularyKey("LoadDate", "Load Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyKey = group.Add(new VocabularyKey("PartyKey", "Party Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullName = group.Add(new VocabularyKey("FullName", "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey("Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerCode = group.Add(new VocabularyKey("BrokerCode", "Broker Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerUAGCode = group.Add(new VocabularyKey("BrokerUAGCode", "Broker UAG Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey PolicyKey { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LoadDate { get; private set; }
        public VocabularyKey PartyKey { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey BrokerCode { get; private set; }
        public VocabularyKey BrokerUAGCode { get; private set; }
    }
}

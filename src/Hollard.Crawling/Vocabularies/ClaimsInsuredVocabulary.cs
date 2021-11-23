using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace CluedIn.Crawling.Hollard.Vocabularies
{
    public class  ClaimsInsuredVocabulary : SimpleVocabulary
    {
        public  ClaimsInsuredVocabulary()
        {
            VocabularyName = "Hollard ClaimsInsured"; 
            KeyPrefix      = "hollard.claimsinsured"; 
            KeySeparator   = ".";
            Grouping       = HollardEntities.ClaimsInsured; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Hollard ClaimsInsured Details", group =>
            {
                PolicyKey = group.Add(new VocabularyKey("PolicyKey", "Policy Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadDate = group.Add(new VocabularyKey("LoadDate", "Load Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyKey = group.Add(new VocabularyKey("PartyKey", "Party Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey("Phone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuranceDeclinePast = group.Add(new VocabularyKey("InsuranceDeclinePast", "Insurance Decline Past", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullName = group.Add(new VocabularyKey("FullName", "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Birthdate = group.Add(new VocabularyKey("Birthdate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey("AddressLine1", "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey("PostalCode", "Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateName = group.Add(new VocabularyKey("StateName", "State Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            AddMapping(Phone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.PhoneNumber);
            AddMapping(Birthdate, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Birthday);
            AddMapping(AddressLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddress);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressCity);
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressPostOfficeBox);
            AddMapping(StateName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressState);
        }

        public VocabularyKey PolicyKey { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LoadDate { get; private set; }
        public VocabularyKey PartyKey { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey InsuranceDeclinePast { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey Birthdate { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey StateName { get; private set; }
    }
}

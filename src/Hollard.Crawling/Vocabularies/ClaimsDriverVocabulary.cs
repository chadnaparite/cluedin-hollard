using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace CluedIn.Crawling.Hollard.Vocabularies
{
    public class  ClaimsDriverVocabulary : SimpleVocabulary
    {
        public  ClaimsDriverVocabulary()
        {
            VocabularyName = "Hollard ClaimsDriver"; 
            KeyPrefix      = "hollard.claimsdriver"; 
            KeySeparator   = ".";
            Grouping       = HollardEntities.ClaimsDriver; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Hollard ClaimsDriver Details", group =>
            {
                PolicyKey = group.Add(new VocabularyKey("PolicyKey", "Policy Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadDate = group.Add(new VocabularyKey("LoadDate", "Load Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DriverID = group.Add(new VocabularyKey("DriverID", "Driver ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleID = group.Add(new VocabularyKey("VehicleID", "Vehicle ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey("LastName", "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfBirth = group.Add(new VocabularyKey("DateOfBirth", "Date Of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateLicensed = group.Add(new VocabularyKey("DateLicensed", "Date Licensed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriminalConviction = group.Add(new VocabularyKey("CriminalConviction", "Criminal Conviction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuspensionStatus = group.Add(new VocabularyKey("SuspensionStatus", "Suspension Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.LastName);
            AddMapping(DateOfBirth, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Birthday);
        }

        public VocabularyKey PolicyKey { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LoadDate { get; private set; }
        public VocabularyKey DriverID { get; private set; }
        public VocabularyKey VehicleID { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey DateOfBirth { get; private set; }
        public VocabularyKey DateLicensed { get; private set; }
        public VocabularyKey CriminalConviction { get; private set; }
        public VocabularyKey SuspensionStatus { get; private set; }
    }
}

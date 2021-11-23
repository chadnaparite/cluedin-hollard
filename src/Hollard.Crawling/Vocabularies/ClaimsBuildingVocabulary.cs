using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace CluedIn.Crawling.Hollard.Vocabularies
{
    public class  ClaimsBuildingVocabulary : SimpleVocabulary
    {
        public  ClaimsBuildingVocabulary()
        {
            VocabularyName = "Hollard ClaimsBuilding"; 
            KeyPrefix      = "hollard.claimsbuilding"; 
            KeySeparator   = ".";
            Grouping       = HollardEntities.ClaimsBuilding; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Hollard ClaimsBuilding Details", group =>
            {
                PolicyKey = group.Add(new VocabularyKey("PolicyKey", "Policy Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadDate = group.Add(new VocabularyKey("LoadDate", "Load Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyID = group.Add(new VocabularyKey("PropertyID", "Property ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuildingSumInsured = group.Add(new VocabularyKey("BuildingSumInsured", "Building Sum Insured", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey("AddressLine1", "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey("PostalCode", "Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateName = group.Add(new VocabularyKey("StateName", "State Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlarmSecurity = group.Add(new VocabularyKey("AlarmSecurity", "Alarm Security", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternallyAccessDoor = group.Add(new VocabularyKey("ExternallyAccessDoor", "Externally Access Door", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternallyAccessWindow = group.Add(new VocabularyKey("ExternallyAccessWindow", "Externally Access Window", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interestedparties = group.Add(new VocabularyKey("InterestedParties", "Interested Parties", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfLevels = group.Add(new VocabularyKey("NumberOfLevels", "Number Of Levels", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OccupancyType = group.Add(new VocabularyKey("OccupancyType", "Occupancy Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quality = group.Add(new VocabularyKey("Quality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoofConstruction = group.Add(new VocabularyKey("RoofConstruction", "Roof Construction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WallConstruction = group.Add(new VocabularyKey("WallConstruction", "Wall Construction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearBuild = group.Add(new VocabularyKey("YearBuild", "Year Build", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            AddMapping(AddressLine1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddress);
            AddMapping(City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressCity);
            AddMapping(PostalCode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressPostOfficeBox);
            AddMapping(StateName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.HomeAddressState);
        }

        public VocabularyKey PolicyKey { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LoadDate { get; private set; }
        public VocabularyKey PropertyID { get; private set; }
        public VocabularyKey BuildingSumInsured { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey StateName { get; private set; }
        public VocabularyKey AlarmSecurity { get; private set; }
        public VocabularyKey ExternallyAccessDoor { get; private set; }
        public VocabularyKey ExternallyAccessWindow { get; private set; }
        public VocabularyKey Interestedparties { get; private set; }
        public VocabularyKey NumberOfLevels { get; private set; }
        public VocabularyKey OccupancyType { get; private set; }
        public VocabularyKey Quality { get; private set; }
        public VocabularyKey RoofConstruction { get; private set; }
        public VocabularyKey WallConstruction { get; private set; }
        public VocabularyKey YearBuild { get; private set; }
    }
}

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace CluedIn.Crawling.Hollard.Vocabularies
{
    public class  ClaimsVehicleVocabulary : SimpleVocabulary
    {
        public  ClaimsVehicleVocabulary()
        {
            VocabularyName = "Hollard ClaimsVehicle"; 
            KeyPrefix      = "hollard.claimsvehicle"; 
            KeySeparator   = ".";
            Grouping       = HollardEntities.ClaimsVehicle; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Hollard ClaimsVehicle Details", group =>
            {
                PolicyKey = group.Add(new VocabularyKey("PolicyKey", "Policy Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadDate = group.Add(new VocabularyKey("LoadDate", "Load Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleID = group.Add(new VocabularyKey("VehicleID", "Vehicle ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Model = group.Add(new VocabularyKey("Model", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Make = group.Add(new VocabularyKey("Make", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Year = group.Add(new VocabularyKey("Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GlassCode = group.Add(new VocabularyKey("GlassCode", "Glass Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NVICCode = group.Add(new VocabularyKey("NVICCode", "NVIC Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey("RegistrationNumber", "Registration Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumInsuredType = group.Add(new VocabularyKey("SumInsuredType", "Sum Insured Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialStatus = group.Add(new VocabularyKey("FinancialStatus", "Financial Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParkingAddress = group.Add(new VocabularyKey("ParkingAddress", "Parking Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Usage = group.Add(new VocabularyKey("Usage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HailDamage = group.Add(new VocabularyKey("HailDamage", "Hail Damage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleSumInsured = group.Add(new VocabularyKey("VehicleSumInsured", "Vehicle Sum Insured", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModificationCover = group.Add(new VocabularyKey("ModificationCover", "Modification Cover", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonStandardAccessory = group.Add(new VocabularyKey("NonStandardAccessory", "Non Standard Accessory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }

        public VocabularyKey PolicyKey { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LoadDate { get; private set; }
        public VocabularyKey VehicleID { get; private set; }
        public VocabularyKey Model { get; private set; }
        public VocabularyKey Make { get; private set; }
        public VocabularyKey Year { get; private set; }
        public VocabularyKey GlassCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey NVICCode { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey SumInsuredType { get; private set; }
        public VocabularyKey FinancialStatus { get; private set; }
        public VocabularyKey ParkingAddress { get; private set; }
        public VocabularyKey Usage { get; private set; }
        public VocabularyKey HailDamage { get; private set; }
        public VocabularyKey VehicleSumInsured { get; private set; }
        public VocabularyKey ModificationCover { get; private set; }
        public VocabularyKey NonStandardAccessory { get; private set; }
    }
}

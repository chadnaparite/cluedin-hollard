using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Hollard.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Models;

namespace CluedIn.Crawling.Hollard.ClueProducers
{
    public class ClaimsVehicleClueProducer : BaseClueProducer<ClaimsVehicle>
    {
        private readonly IClueFactory factory;

        public ClaimsVehicleClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(ClaimsVehicle input, Guid accountId)
        {
            var claimsvehicleVocabulary = new ClaimsVehicleVocabulary();
            var clue = factory.Create(claimsvehicleVocabulary.Grouping, input.VehicleID, accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.RegistrationNumber != null)
            {
                data.Name = input.RegistrationNumber;
                data.DisplayName = input.RegistrationNumber;
                data.Description = input.RegistrationNumber;
            }



            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }


            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[claimsvehicleVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[claimsvehicleVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
            // }


            //TODO: Example of PersonReference
            //  if (input.UpdatedBy != null)
            // {
            //     if (input.UpdatedByName != null)
            //     {
            //         var updatedPersonReference = new PersonReference(input.UpdatedByName, new EntityCode(EntityType.Person, HollardConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            //     else
            //     {
            //         var updatedPersonReference = new PersonReference(new EntityCode(EntityType.Person, HollardConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            // }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[claimsvehicleVocabulary.PolicyKey] = input.PolicyKey.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.LoadDate] = input.LoadDate.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.VehicleID] = input.VehicleID.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.Model] = input.Model.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.Make] = input.Make.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.Year] = input.Year.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.GlassCode] = input.GlassCode.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.Description] = input.Description.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.NVICCode] = input.NVICCode.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.RegistrationNumber] = input.RegistrationNumber.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.State] = input.State.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.SumInsuredType] = input.SumInsuredType.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.FinancialStatus] = input.FinancialStatus.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.ParkingAddress] = input.ParkingAddress.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.Usage] = input.Usage.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.HailDamage] = input.HailDamage.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.VehicleSumInsured] = input.VehicleSumInsured.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.ModificationCover] = input.ModificationCover.PrintIfAvailable();
            data.Properties[claimsvehicleVocabulary.NonStandardAccessory] = input.NonStandardAccessory.PrintIfAvailable();

            return clue;
        }
    }
}

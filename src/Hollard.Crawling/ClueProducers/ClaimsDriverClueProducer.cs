using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Hollard.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Models;

namespace CluedIn.Crawling.Hollard.ClueProducers
{
    public class ClaimsDriverClueProducer : BaseClueProducer<ClaimsDriver>
    {
        private readonly IClueFactory factory;

        public ClaimsDriverClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(ClaimsDriver input, Guid accountId)
        {
            var claimsdriverVocabulary = new ClaimsDriverVocabulary();
            var clue = factory.Create(claimsdriverVocabulary.Grouping, input.DriverID, accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
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
            //     data.Properties[claimsdriverVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[claimsdriverVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[claimsdriverVocabulary.PolicyKey] = input.PolicyKey.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.LoadDate] = input.LoadDate.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.DriverID] = input.DriverID.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.VehicleID] = input.VehicleID.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.DateOfBirth] = input.DateOfBirth.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.DateLicensed] = input.DateLicensed.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.CriminalConviction] = input.CriminalConviction.PrintIfAvailable();
            data.Properties[claimsdriverVocabulary.SuspensionStatus] = input.SuspensionStatus.PrintIfAvailable();

            return clue;
        }
    }
}

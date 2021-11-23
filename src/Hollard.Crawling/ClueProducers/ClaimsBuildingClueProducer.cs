using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Hollard.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Models;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace CluedIn.Crawling.Hollard.ClueProducers
{
    public class ClaimsBuildingClueProducer : BaseClueProducer<ClaimsBuilding>
    {
        private readonly IClueFactory factory;

        public ClaimsBuildingClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(ClaimsBuilding input, Guid accountId)
        {
            var claimsbuildingVocabulary = new ClaimsBuildingVocabulary();
            var clue = factory.Create(claimsbuildingVocabulary.Grouping, input.PropertyID, accountId);
            var data = clue.Data.EntityData;

            if (input.StateName != null)
            {
                data.Name = input.StateName;
                data.DisplayName = input.StateName;
                data.Description = input.StateName;
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
            //     data.Properties[claimsbuildingVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            if (input.PolicyKey != null)
            {
                factory.CreateIncomingEntityReference(clue, HollardEntities.ClaimsPolicy, HollardEdgeType.Related, input.PolicyKey, input.PolicyKey);
            }


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
            data.Properties[claimsbuildingVocabulary.PolicyKey] = input.PolicyKey.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.LoadDate] = input.LoadDate.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.PropertyID] = input.PropertyID.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.BuildingSumInsured] = input.BuildingSumInsured.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.AddressLine1] = input.AddressLine1.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.City] = input.City.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.StateName] = input.StateName.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.AlarmSecurity] = input.AlarmSecurity.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.ExternallyAccessDoor] = input.ExternallyAccessDoor.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.ExternallyAccessWindow] = input.ExternallyAccessWindow.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.Interestedparties] = input.Interestedparties.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.NumberOfLevels] = input.NumberOfLevels.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.OccupancyType] = input.OccupancyType.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.Quality] = input.Quality.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.RoofConstruction] = input.RoofConstruction.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.WallConstruction] = input.WallConstruction.PrintIfAvailable();
            data.Properties[claimsbuildingVocabulary.YearBuild] = input.YearBuild.PrintIfAvailable();

            return clue;
        }
    }
}

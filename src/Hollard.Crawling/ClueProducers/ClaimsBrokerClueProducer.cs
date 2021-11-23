using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Hollard.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Models;

namespace CluedIn.Crawling.Hollard.ClueProducers
{
    public class ClaimsBrokerClueProducer : BaseClueProducer<ClaimsBroker>
    {
        private readonly IClueFactory factory;

        public ClaimsBrokerClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(ClaimsBroker input, Guid accountId)
        {
            var claimsbrokerVocabulary = new ClaimsBrokerVocabulary();
            var clue = factory.Create(claimsbrokerVocabulary.Grouping, input.PolicyKey, accountId);
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
            //     data.Properties[claimsbrokerVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[claimsbrokerVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[claimsbrokerVocabulary.PolicyKey] = input.PolicyKey.PrintIfAvailable();
            data.Properties[claimsbrokerVocabulary.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[claimsbrokerVocabulary.LoadDate] = input.LoadDate.PrintIfAvailable();
            data.Properties[claimsbrokerVocabulary.PartyKey] = input.PartyKey.PrintIfAvailable();
            data.Properties[claimsbrokerVocabulary.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[claimsbrokerVocabulary.Phone] = input.Phone.PrintIfAvailable();
            data.Properties[claimsbrokerVocabulary.BrokerCode] = input.BrokerCode.PrintIfAvailable();
            data.Properties[claimsbrokerVocabulary.BrokerUAGCode] = input.BrokerUAGCode.PrintIfAvailable();

            return clue;
        }
    }
}

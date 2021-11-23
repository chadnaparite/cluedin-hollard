using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Hollard.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Models;

namespace CluedIn.Crawling.Hollard.ClueProducers
{
    public class ClaimsInsuredClueProducer : BaseClueProducer<ClaimsInsured>
    {
        private readonly IClueFactory factory;

        public ClaimsInsuredClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(ClaimsInsured input, Guid accountId)
        {
            var claimsinsuredVocabulary = new ClaimsInsuredVocabulary();
            var clue = factory.Create(claimsinsuredVocabulary.Grouping, input.PolicyKey, accountId);
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
            //     data.Properties[claimsinsuredVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[claimsinsuredVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[claimsinsuredVocabulary.PolicyKey] = input.PolicyKey.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.LoadDate] = input.LoadDate.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.PartyKey] = input.PartyKey.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.Phone] = input.Phone.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.InsuranceDeclinePast] = input.InsuranceDeclinePast.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.FullName] = input.FullName.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.Birthdate] = input.Birthdate.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.AddressLine1] = input.AddressLine1.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.City] = input.City.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.PostalCode] = input.PostalCode.PrintIfAvailable();
            data.Properties[claimsinsuredVocabulary.StateName] = input.StateName.PrintIfAvailable();

            return clue;
        }
    }
}

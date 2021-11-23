using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Hollard.Vocabularies;
using CluedIn.Crawling.Hollard.Core.Models;

namespace CluedIn.Crawling.Hollard.ClueProducers
{
    public class ClaimsPolicyClueProducer : BaseClueProducer<ClaimsPolicy>
    {
        private readonly IClueFactory factory;

        public ClaimsPolicyClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(ClaimsPolicy input, Guid accountId)
        {
            var claimspolicyVocabulary = new ClaimsPolicyVocabulary();

            // TODO: Verify EntityType and identifier are correct
            var clue = factory.Create(claimspolicyVocabulary.Grouping, input.PolicyKey, accountId);

            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.PolicyNumber != null)
            {
                data.Name = input.PolicyNumber;
                data.DisplayName = input.PolicyNumber;
                data.Description = input.PolicyNumber;
            }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[claimspolicyVocabulary.PolicyKey] = input.PolicyKey.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.LoadDate] = input.LoadDate.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.PolicyNumber] = input.PolicyNumber.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.PaymentPlan] = input.PaymentPlan.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.EffectiveDate] = input.EffectiveDate.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.ExpirationDate] = input.ExpirationDate.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.Brand] = input.Brand.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.Product] = input.Product.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.PolicySourcePlatform] = input.PolicySourcePlatform.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.PolicyType] = input.PolicyType.PrintIfAvailable();
            data.Properties[claimspolicyVocabulary.UnderWritingCompany] = input.UnderWritingCompany.PrintIfAvailable();

            return clue;
        }
    }
}

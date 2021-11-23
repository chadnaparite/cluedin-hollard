using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Hollard.ClueProducers;
using CluedIn.Crawling.Hollard.Core.Models;
using CluedIn.Crawling.Hollard.Core.Constants;

namespace Crawling.Hollard.Unit.Test.ClueProducers
{
    public class ClaimsPolicyClueProducerTests : BaseClueProducerTest<ClaimsPolicy>
    {
        protected override BaseClueProducer<ClaimsPolicy> Sut =>
            new ClaimsPolicyClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => HollardEntities.ClaimsPolicy;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(ClaimsPolicy claimspolicy)
        {
            var clue = Sut.MakeClue(claimspolicy, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}

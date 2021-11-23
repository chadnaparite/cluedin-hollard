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
    public class ClaimsInsuredClueProducerTests : BaseClueProducerTest<ClaimsInsured>
    {
        protected override BaseClueProducer<ClaimsInsured> Sut =>
            new ClaimsInsuredClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => HollardEntities.ClaimsInsured;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(ClaimsInsured claimsinsured)
        {
            var clue = Sut.MakeClue(claimsinsured, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}

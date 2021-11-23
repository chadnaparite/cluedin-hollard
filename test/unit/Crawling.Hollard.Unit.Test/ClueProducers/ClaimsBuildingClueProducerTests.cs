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
    public class ClaimsBuildingClueProducerTests : BaseClueProducerTest<ClaimsBuilding>
    {
        protected override BaseClueProducer<ClaimsBuilding> Sut =>
            new ClaimsBuildingClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => HollardEntities.ClaimsBuilding;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(ClaimsBuilding claimsbuilding)
        {
            var clue = Sut.MakeClue(claimsbuilding, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}

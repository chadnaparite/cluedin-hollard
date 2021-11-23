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
    public class ClaimsBrokerClueProducerTests : BaseClueProducerTest<ClaimsBroker>
    {
        protected override BaseClueProducer<ClaimsBroker> Sut =>
            new ClaimsBrokerClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => HollardEntities.ClaimsBroker;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(ClaimsBroker claimsbroker)
        {
            var clue = Sut.MakeClue(claimsbroker, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}

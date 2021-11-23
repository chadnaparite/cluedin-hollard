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
    public class ClaimsDriverClueProducerTests : BaseClueProducerTest<ClaimsDriver>
    {
        protected override BaseClueProducer<ClaimsDriver> Sut =>
            new ClaimsDriverClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => HollardEntities.ClaimsDriver;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(ClaimsDriver claimsdriver)
        {
            var clue = Sut.MakeClue(claimsdriver, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}

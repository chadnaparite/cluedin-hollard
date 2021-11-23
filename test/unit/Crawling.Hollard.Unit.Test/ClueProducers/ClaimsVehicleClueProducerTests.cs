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
    public class ClaimsVehicleClueProducerTests : BaseClueProducerTest<ClaimsVehicle>
    {
        protected override BaseClueProducer<ClaimsVehicle> Sut =>
            new ClaimsVehicleClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => HollardEntities.ClaimsVehicle;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(ClaimsVehicle claimsvehicle)
        {
            var clue = Sut.MakeClue(claimsvehicle, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}

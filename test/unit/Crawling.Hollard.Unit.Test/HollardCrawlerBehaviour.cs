using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Hollard;
using CluedIn.Crawling.Hollard.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Hollard.Unit.Test
{
    public class HollardCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public HollardCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IHollardClientFactory>();

            _sut = new HollardCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}

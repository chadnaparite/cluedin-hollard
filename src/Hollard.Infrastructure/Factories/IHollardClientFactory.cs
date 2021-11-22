using CluedIn.Crawling.Hollard.Core;

namespace CluedIn.Crawling.Hollard.Infrastructure.Factories
{
    public interface IHollardClientFactory
    {
        HollardClient CreateNew(HollardCrawlJobData HollardCrawlJobData);
    }
}

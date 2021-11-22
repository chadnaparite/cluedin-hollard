using CluedIn.Crawling.Hollard.Core;

namespace CluedIn.Crawling.Hollard
{
    public class HollardCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<HollardCrawlJobData>
    {
        public HollardCrawlerJobProcessor(HollardCrawlerComponent component) : base(component)
        {
        }
    }
}

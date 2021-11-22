using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Hollard.Core;
using CluedIn.Crawling.Hollard.Infrastructure.Factories;

namespace CluedIn.Crawling.Hollard
{
    public class HollardCrawler : ICrawlerDataGenerator
    {
        private readonly IHollardClientFactory clientFactory;
        public HollardCrawler(IHollardClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is HollardCrawlJobData HollardcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(HollardcrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}

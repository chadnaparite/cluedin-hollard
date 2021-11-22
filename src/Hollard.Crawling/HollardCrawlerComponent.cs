using CluedIn.Core;
using CluedIn.Crawling.Hollard.Core;

using ComponentHost;

namespace CluedIn.Crawling.Hollard
{
    [Component(HollardConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class HollardCrawlerComponent : CrawlerComponentBase
    {
        public HollardCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}


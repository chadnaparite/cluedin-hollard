using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Hollard.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Hollard.Unit.Test.HollardProvider
{
    public abstract class HollardProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IHollardClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected HollardProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IHollardClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Hollard.HollardProvider(applicationContext, NameClientFactory.Object);
        }
    }
}

using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace UITest.Tests.Features
{
    public class FeatureBase
    {
        private readonly Platform _platform;
        protected static IApp App;

        public FeatureBase(Platform platform)
        {
            _platform = platform;
        }

        [SetUp]
        public void BeforeEachTestStart()
        {
            App = AppInitializer.StartApp(_platform);
            FeatureContext.Current.Add(nameof(App), App);
        }
    }
}
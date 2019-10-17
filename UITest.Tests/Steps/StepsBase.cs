using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace UITest.Tests.Steps
{
    public class StepsBase
    {
        protected readonly IApp App; 

        public StepsBase()
        {
            App = FeatureContext.Current.Get<IApp>(nameof(App));
        }
    }
}
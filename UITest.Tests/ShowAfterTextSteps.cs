using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace UITest.Tests
{
    [Binding]
    public class ShowAfterTextSteps
    {
        private IApp app;

        [Given("I am on the Initial screen")]
        public void InitialScreenIsDisplayed()
        {
            app = AppInitializer.StartApp(Platform.Android);
        }
        
        [When("I press the button")]
        public void WhenIPressAdd()
        {
            app.Tap(c => c.Marked("button"));
        }

        [Then("I should see AFTER text in the editor")]
        public void ThenTheResultShouldBe()
        {
            var result = app.Query(c => c.Marked("editor").Text("AFTER"));

            Assert.IsTrue(result.Any());
        }
    }
}

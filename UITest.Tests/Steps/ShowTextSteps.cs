using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace UITest.Tests.Steps
{
    [Binding]
    public class ShowTextSteps : StepsBase
    {
        [Given(@"I am on the Initial screen")]
        public void InitialScreenInitialization()
        {

        }

        [When(@"I press the button")]
        public void ButtonPressing()
        {
            App.Tap(c => c.Marked("button"));
        }

        [Then(@"I should see AFTER text in the editor")]
        public void CheckResult()
        {
            var result = App.Query(c => c.Marked("editor").Text("AFTER"));

            Assert.IsTrue(result.Any());
        }
    }
}
using NUnit.Framework;
using Xamarin.UITest;

namespace UITest.Tests.Features
{
    [TestFixture(Platform.iOS)]
    [TestFixture(Platform.Android)]
    public partial class ShowTextFeature : FeatureBase
    {
        public ShowTextFeature(Platform platform):base(platform)
        {
        }
    }
}
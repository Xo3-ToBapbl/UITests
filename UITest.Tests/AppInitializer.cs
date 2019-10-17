using System;
using Xamarin.UITest;

namespace UITest.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .StartApp();
            }
            if (platform == Platform.iOS)
            {
                return ConfigureApp
                    .iOS
                    .StartApp();
            }

            throw new PlatformNotSupportedException($"{nameof(platform)}");
        }
    }
}
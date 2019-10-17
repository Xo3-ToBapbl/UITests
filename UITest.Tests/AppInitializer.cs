using System;
using System.IO;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                path = Directory.GetParent(path).Parent.Parent.Parent.FullName;
                path = Path.Combine(path, @"UITest.Droid\bin\Release\com.companyname.uitest.droid.apk");

                return ConfigureApp
                    .Android
                    .ApkFile(path)
                    .Debug()
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}
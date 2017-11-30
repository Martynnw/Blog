using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Configuration;
using Xamarin.UITest.Queries;

namespace AutomatedStateTesting.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform, bool preseveData = false)
        {
            var dataMode = preseveData ? AppDataMode.DoNotClear : AppDataMode.Clear;

            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    .StartApp(dataMode);
            }
            else
            {
                return ConfigureApp.iOS
                   .StartApp(dataMode);
            }
        }
    }
}

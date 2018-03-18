using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace SpecFlowDemo.UITests
{
    public static class Global
    {
        public static Platform Platform { get; set; }
        public static IApp App { get; set; }
    }

    [TestFixture(Platform.iOS)]
    [TestFixture(Platform.Android)]
    public partial class LogInToAppFeature
    {
        public LogInToAppFeature(Platform platform)
        {
            Global.Platform = platform;
        }
    }
}

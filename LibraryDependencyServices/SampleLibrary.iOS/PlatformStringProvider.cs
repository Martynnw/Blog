using System;
using SampleLibrary.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformStringProvider))]
namespace SampleLibrary.iOS
{
    public class PlatformStringProvider : IPlatformStringProvider
    {
        public PlatformStringProvider()
        {
        }

        public string GetPlatformString()
        {
            return "This is iOS!";
        }
    }
}

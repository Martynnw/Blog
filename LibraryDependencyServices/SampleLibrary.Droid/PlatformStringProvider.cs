using System;
using SampleLibrary.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformStringProvider))]
namespace SampleLibrary.Droid
{
    public class PlatformStringProvider : IPlatformStringProvider
    {
        public PlatformStringProvider()
        {
        }

        public string GetPlatformString()
        {
            return "This is Android!";
        }
    }
}

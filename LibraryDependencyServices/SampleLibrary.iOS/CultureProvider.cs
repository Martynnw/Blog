using System;
using SampleLibrary.iOS;
using Xamarin.Forms;
using System.Threading;

[assembly: Dependency(typeof(CultureProvider))]
namespace SampleLibrary.iOS
{
    public class CultureProvider : ICultureProvider
    {
        public CultureProvider()
        {
        }

        public string GetCultureString()
        {
            return Thread.CurrentThread.CurrentCulture.ToString();
        }
    }
}

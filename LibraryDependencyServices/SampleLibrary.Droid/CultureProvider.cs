using System;
using SampleLibrary.Droid;
using Xamarin.Forms;
using System.Threading;

[assembly: Dependency(typeof(CultureProvider))]
namespace SampleLibrary.Droid
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

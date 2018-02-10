using System;
namespace SampleLibrary
{
    public class TimeProvider
    {
        public TimeProvider()
        {
        }

        public string GetTimeString()
        {
            return DateTime.Now.ToString("t");
        }
    }
}

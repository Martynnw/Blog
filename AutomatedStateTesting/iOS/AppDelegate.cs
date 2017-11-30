using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AutomatedStateTesting.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
            Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        [Export("SuspendApp:")]
        public void SuspendApp(NSString value)
        {
            UIApplication.SharedApplication.PerformSelector(new ObjCRuntime.Selector("suspend"), null, 2.0);
        }
    }
}

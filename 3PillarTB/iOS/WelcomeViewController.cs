using System;

using UIKit;

namespace PillarTB.iOS
{
	public partial class WelcomeViewController : UIViewController
	{
		public WelcomeViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void ContinueButton_TouchUpInside (UIButton sender)
		{
			var tabsController = Storyboard.InstantiateViewController("DashboardTabsController");
			var window = UIApplication.SharedApplication.KeyWindow;
			window.RootViewController = tabsController;
		}
	}
}



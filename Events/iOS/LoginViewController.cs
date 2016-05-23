using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Events.iOS
{
	partial class LoginViewController : UIViewController
	{
		public LoginViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Title = "";
		}
			
		partial void LoginButton_TouchUpInside (UIButton sender)
		{
			var dashboardTabBarController = Storyboard.InstantiateViewController("DashboardTabBarController");
			var window = UIApplication.SharedApplication.KeyWindow;
			window.RootViewController = dashboardTabBarController;
		}
	}
}

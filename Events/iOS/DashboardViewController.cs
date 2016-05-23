using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Events.iOS
{
	partial class DashboardViewController : UITabBarController
	{
		public DashboardViewController (IntPtr handle) : base (handle)
		{
			UITabBarItem.Appearance.SetTitleTextAttributes(new UITextAttributes() { TextColor = UIColor.White }, UIControlState.Selected);
		}
	}
}

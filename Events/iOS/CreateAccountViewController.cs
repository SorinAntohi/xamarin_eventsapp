using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Events.iOS
{
	partial class CreateAccountViewController : UIViewController
	{
		public CreateAccountViewController (IntPtr handle) : base (handle)
		{
		}
			
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			NavigationController.NavigationBarHidden = false;
		}

		public override void ViewWillDisappear (bool animated)
		{
			NavigationController.NavigationBarHidden = true;
			base.ViewWillDisappear (animated);
		}
	}
}

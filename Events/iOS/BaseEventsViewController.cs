using System;

using UIKit;

namespace Events.iOS
{
	public partial class BaseEventsViewController : UIViewController
	{

		public BaseEventsViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
		}
	}
}



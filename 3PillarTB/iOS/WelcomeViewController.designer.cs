// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PillarTB.iOS
{
	[Register ("WelcomeViewController")]
	partial class WelcomeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ContinueButton { get; set; }

		[Action ("ContinueButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void ContinueButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (ContinueButton != null) {
				ContinueButton.Dispose ();
				ContinueButton = null;
			}
		}
	}
}

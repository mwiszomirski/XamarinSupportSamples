using System;
using MonoTouch.UIKit;

namespace com.xamarin.university.mobilenav.ios.flyout
{
	public class EvolveFlyoutViewControllerBase : UIViewController
	{
		public EvolveFlyoutViewControllerBase ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var bbi = new UIBarButtonItem(UIImage.FromBundle ("images/slideout.png"), UIBarButtonItemStyle.Plain, (sender, e) => {
				AppDelegate.FlyoutNav.ToggleMenu();
			});
			NavigationItem.SetLeftBarButtonItem (bbi, false);
		}
	}
}
// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace test1
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton _mButtonChoise1 { get; set; }

		[Outlet]
		UIKit.UIButton _mButtonChoise2 { get; set; }

		[Outlet]
		UIKit.UIButton _mButtonChoise3 { get; set; }

		[Outlet]
		UIKit.UIButton _mButtonChoise4 { get; set; }

		[Outlet]
		UIKit.UILabel _mLabel { get; set; }

		[Outlet]
		UIKit.UIButton _mTestButton { get; set; }

		[Action ("OnClickButtonChoise1:")]
		partial void OnClickButtonChoise1 (Foundation.NSObject sender);

		[Action ("OnClickButtonChoise2:")]
		partial void OnClickButtonChoise2 (Foundation.NSObject sender);

		[Action ("OnClickButtonChoise3:")]
		partial void OnClickButtonChoise3 (Foundation.NSObject sender);

		[Action ("OnClickButtonChoise4:")]
		partial void OnClickButtonChoise4 (Foundation.NSObject sender);

		[Action ("OnClickButtonTest:")]
		partial void OnClickButtonTest (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_mLabel != null) {
				_mLabel.Dispose ();
				_mLabel = null;
			}

			if (_mButtonChoise4 != null) {
				_mButtonChoise4.Dispose ();
				_mButtonChoise4 = null;
			}

			if (_mButtonChoise3 != null) {
				_mButtonChoise3.Dispose ();
				_mButtonChoise3 = null;
			}

			if (_mButtonChoise2 != null) {
				_mButtonChoise2.Dispose ();
				_mButtonChoise2 = null;
			}

			if (_mButtonChoise1 != null) {
				_mButtonChoise1.Dispose ();
				_mButtonChoise1 = null;
			}

			if (_mTestButton != null) {
				_mTestButton.Dispose ();
				_mTestButton = null;
			}
		}
	}
}

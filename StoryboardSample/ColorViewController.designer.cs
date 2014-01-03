// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SWRevealExample
{
	[Register ("ColorViewController")]
	partial class ColorViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel DummyLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem RevealButtonItem { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RevealButtonItem != null) {
				RevealButtonItem.Dispose ();
				RevealButtonItem = null;
			}

			if (DummyLabel != null) {
				DummyLabel.Dispose ();
				DummyLabel = null;
			}
		}
	}
}

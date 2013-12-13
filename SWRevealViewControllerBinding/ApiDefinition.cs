using System.Drawing;
using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SWRevealViewControllerBinding
{
	[BaseType (typeof(UIViewController))]
	public partial interface SWRevealViewController
	{
		[Export ("initWithRearViewController:frontViewController:")]
		IntPtr Constructor (UIViewController rearViewController, UIViewController frontViewController);

		[Export ("rearViewController", ArgumentSemantic.Retain)]
		UIViewController RearViewController { get; set; }

		[Export ("rightViewController", ArgumentSemantic.Retain)]
		UIViewController RightViewController { get; set; }

		[Export ("frontViewController", ArgumentSemantic.Retain)]
		UIViewController FrontViewController { get; set; }

		[Export ("setFrontViewController:animated:")]
		void SetFrontViewController (UIViewController frontViewController, bool animated);

		[Export ("frontViewPosition")]
		FrontViewPosition FrontViewPosition { get; set; }

		[Export ("setFrontViewPosition:animated:")]
		void SetFrontViewPosition (FrontViewPosition frontViewPosition, bool animated);

		[Export ("revealToggleAnimated:")]
		void RevealToggleAnimated (bool animated);

		[Export ("rightRevealToggleAnimated:")]
		void RightRevealToggleAnimated (bool animated);

		[Export ("revealToggle:")]
		void RevealToggle (NSObject sender);

		[Export ("rightRevealToggle:")]
		void RightRevealToggle (NSObject sender);

		[Export ("panGestureRecognizer")]
		UIPanGestureRecognizer PanGestureRecognizer { get; }

		[Export ("tapGestureRecognizer")]
		UITapGestureRecognizer TapGestureRecognizer { get; }

		[Export ("rearViewRevealWidth")]
		float RearViewRevealWidth { get; set; }

		[Export ("rightViewRevealWidth")]
		float RightViewRevealWidth { get; set; }

		[Export ("rearViewRevealOverdraw")]
		float RearViewRevealOverdraw { get; set; }

		[Export ("rightViewRevealOverdraw")]
		float RightViewRevealOverdraw { get; set; }

		[Export ("rearViewRevealDisplacement")]
		float RearViewRevealDisplacement { get; set; }

		[Export ("rightViewRevealDisplacement")]
		float RightViewRevealDisplacement { get; set; }

		[Export ("draggableBorderWidth")]
		float DraggableBorderWidth { get; set; }

		[Export ("bounceBackOnOverdraw")]
		bool BounceBackOnOverdraw { get; set; }

		[Export ("bounceBackOnLeftOverdraw")]
		bool BounceBackOnLeftOverdraw { get; set; }

		[Export ("stableDragOnOverdraw")]
		bool StableDragOnOverdraw { get; set; }

		[Export ("stableDragOnLeftOverdraw")]
		bool StableDragOnLeftOverdraw { get; set; }

		[Export ("presentFrontViewHierarchically")]
		bool PresentFrontViewHierarchically { get; set; }

		[Export ("quickFlickVelocity")]
		float QuickFlickVelocity { get; set; }

		[Export ("toggleAnimationDuration")]
		double ToggleAnimationDuration { get; set; }

		[Export ("frontViewShadowRadius")]
		float FrontViewShadowRadius { get; set; }

		[Export ("frontViewShadowOffset", ArgumentSemantic.Assign)]
		SizeF FrontViewShadowOffset { get; set; }

		[Export ("frontViewShadowOpacity")]
		float FrontViewShadowOpacity { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		SWRevealViewControllerDelegate Delegate { get; set; }
	}

	[Model, BaseType (typeof(NSObject))]
	public partial interface SWRevealViewControllerDelegate
	{
		[Export ("revealController:willMoveToPosition:")]
		void WillMoveToPosition (SWRevealViewController revealController, FrontViewPosition position);

		[Export ("revealController:didMoveToPosition:")]
		void DidMoveToPosition (SWRevealViewController revealController, FrontViewPosition position);

		[Export ("revealController:animateToPosition:")]
		void AnimateToPosition (SWRevealViewController revealController, FrontViewPosition position);

		[Export ("revealControllerPanGestureShouldBegin:")]
		bool PanGestureShouldBegin (SWRevealViewController revealController);

		[Export ("revealControllerTapGestureShouldBegin:")]
		bool TapGeusterShouldBegin (SWRevealViewController revealController);

		[Export ("revealControllerPanGestureBegan:")]
		void PanGestureBegan (SWRevealViewController revealController);

		[Export ("revealControllerPanGestureEnded:")]
		void PanGestureEnded (SWRevealViewController revealController);

		[Export ("revealController:panGestureBeganFromLocation:progress:")]
		void PanGestureBeganFromLocation (SWRevealViewController revealController, float location, float progress);

		[Export ("revealController:panGestureMovedToLocation:progress:")]
		void PanGestureMovedToLocation (SWRevealViewController revealController, float location, float progress);

		[Export ("revealController:panGestureEndedToLocation:progress:")]
		void PanGestureEndedToLocation (SWRevealViewController revealController, float location, float progress);
	}

	[Category, BaseType (typeof(UIViewController))]
	public partial interface SWRevealViewController_UIViewController
	{
		[Export ("revealViewController")]
		SWRevealViewController RevealViewController ();
	}

	public delegate void SegueCallback(SWRevealViewControllerSegue segue, UIViewController svc, UIViewController dvc);

	[BaseType (typeof(UIStoryboardSegue))]
	public partial interface SWRevealViewControllerSegue
	{
		[Export ("performBlock", ArgumentSemantic.Retain)]
		SegueCallback PerformDelegate { get; set; }
	}
}

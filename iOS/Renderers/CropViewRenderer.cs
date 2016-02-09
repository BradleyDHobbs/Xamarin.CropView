using System;
using Xamarin.Forms;
using Xamarin.CropViewSample.iOS;
using Xamarin.CropViewSample;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Foundation;
using Xamarin.CropView;
using System.Diagnostics;

[assembly: ExportRenderer (typeof (CropView), typeof (CropViewRenderer))]
namespace Xamarin.CropViewSample.iOS
{
	public class CropViewRenderer : PageRenderer
	{
		CropViewDelegate selector;
		byte[] Image;
		bool IsShown;
		public bool DidCrop;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var page = base.Element as CropView;
			Image = page.Image;
			DidCrop = page.DidCrop;
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			try 
			{
				if (!IsShown) {

					IsShown = true;

					UIImage image = new UIImage (NSData.FromArray (Image));
					Image = null;

					selector = new CropViewDelegate (this);
					TOCropViewController picker = new TOCropViewController (image);
					picker.Delegate = selector;

					PresentViewController (picker, false, null);

				}
			}
			catch (Exception ex) {
				Debug.WriteLine (ex.Message);
			}
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			try 
			{
				var page = base.Element as CropView;
				page.DidCrop = selector.DidCrop;
			}
			catch (Exception ex) {
				Debug.WriteLine (ex.Message);
			}

		}
	}
}


using System;
using Xamarin.CropView;
using UIKit;
using System.Diagnostics;

namespace Xamarin.CropViewSample.iOS
{
	public class CropViewDelegate : TOCropViewControllerDelegate
	{
		readonly UIViewController parent;
		public bool DidCrop;

		public CropViewDelegate (UIViewController parent)
		{
			this.parent = parent;
		}

		public override void DidCropToImage (TOCropViewController cropViewController, UIImage image, CoreGraphics.CGRect cropRect, nint angle)
		{
			DidCrop = true;

			try 
			{
				if (image != null)
					App.CroppedImage = image.AsPNG().ToArray();

			}
			catch (Exception ex) {
				Debug.WriteLine (ex.Message);
			}
			finally
			{
				if (image != null) {
					image.Dispose ();
					image = null;
				}
			}

			parent.DismissViewController (true, App.PopModal);
		}

		public override void DidFinishCancelled (TOCropViewController cropViewController, bool cancelled)
		{
			parent.DismissViewController (true, App.PopModal);
		}
	}
}


//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Xamarin.CropView {
	public unsafe static partial class UIImage_CropRotate  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIImage");
		
		[Export ("croppedImageWithFrame:angle:")]
		[CompilerGenerated]
		public static global::UIKit.UIImage CroppedImageWithFrame (this global::UIKit.UIImage This, CGRect frame, global::System.nint angle)
		{
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_nint (This.Handle, Selector.GetHandle ("croppedImageWithFrame:angle:"), frame, angle));
		}
		
	} /* class UIImage_CropRotate */
}

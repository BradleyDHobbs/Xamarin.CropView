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
	[Protocol (Name = "TOCropViewControllerDelegate", WrapperType = typeof (TOCropViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCropImageToRect", Selector = "cropViewController:didCropImageToRect:angle:", ParameterType = new Type [] { typeof (Xamarin.CropView.TOCropViewController), typeof (CGRect), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCropToImage", Selector = "cropViewController:didCropToImage:withRect:angle:", ParameterType = new Type [] { typeof (Xamarin.CropView.TOCropViewController), typeof (UIImage), typeof (CGRect), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishCancelled", Selector = "cropViewController:didFinishCancelled:", ParameterType = new Type [] { typeof (Xamarin.CropView.TOCropViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public interface ITOCropViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class TOCropViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidCropImageToRect (this ITOCropViewControllerDelegate This, TOCropViewController cropViewController, CGRect cropRect, global::System.nint angle)
		{
			if (cropViewController == null)
				throw new ArgumentNullException ("cropViewController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect_nint (This.Handle, Selector.GetHandle ("cropViewController:didCropImageToRect:angle:"), cropViewController.Handle, cropRect, angle);
		}
		
		[CompilerGenerated]
		public static void DidCropToImage (this ITOCropViewControllerDelegate This, TOCropViewController cropViewController, global::UIKit.UIImage image, CGRect cropRect, global::System.nint angle)
		{
			if (cropViewController == null)
				throw new ArgumentNullException ("cropViewController");
			if (image == null)
				throw new ArgumentNullException ("image");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_nint (This.Handle, Selector.GetHandle ("cropViewController:didCropToImage:withRect:angle:"), cropViewController.Handle, image.Handle, cropRect, angle);
		}
		
		[CompilerGenerated]
		public static void DidFinishCancelled (this ITOCropViewControllerDelegate This, TOCropViewController cropViewController, bool cancelled)
		{
			if (cropViewController == null)
				throw new ArgumentNullException ("cropViewController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("cropViewController:didFinishCancelled:"), cropViewController.Handle, cancelled);
		}
		
	}
	
	internal sealed class TOCropViewControllerDelegateWrapper : BaseWrapper, ITOCropViewControllerDelegate {
		public TOCropViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public TOCropViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Xamarin.CropView {
	[Protocol]
	[Register("TOCropViewControllerDelegate", false)]
	[Model]
	public unsafe partial class TOCropViewControllerDelegate : NSObject, ITOCropViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TOCropViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected TOCropViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TOCropViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cropViewController:didCropImageToRect:angle:")]
		[CompilerGenerated]
		public virtual void DidCropImageToRect (TOCropViewController cropViewController, CGRect cropRect, global::System.nint angle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cropViewController:didCropToImage:withRect:angle:")]
		[CompilerGenerated]
		public virtual void DidCropToImage (TOCropViewController cropViewController, global::UIKit.UIImage image, CGRect cropRect, global::System.nint angle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("cropViewController:didFinishCancelled:")]
		[CompilerGenerated]
		public virtual void DidFinishCancelled (TOCropViewController cropViewController, bool cancelled)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class TOCropViewControllerDelegate */
}

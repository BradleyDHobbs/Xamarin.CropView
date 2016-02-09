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
	[Register("TOActivityCroppedImageProvider", true)]
	public unsafe partial class TOActivityCroppedImageProvider : global::UIKit.UIActivityItemProvider {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TOActivityCroppedImageProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TOActivityCroppedImageProvider () : base (NSObjectFlag.Empty)
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
		protected TOActivityCroppedImageProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TOActivityCroppedImageProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithImage:cropFrame:angle:")]
		[CompilerGenerated]
		public TOActivityCroppedImageProvider (global::UIKit.UIImage image, CGRect cropFrame, global::System.nint angle)
			: base (NSObjectFlag.Empty)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_nint (this.Handle, Selector.GetHandle ("initWithImage:cropFrame:angle:"), image.Handle, cropFrame, angle), "initWithImage:cropFrame:angle:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect_nint (this.SuperHandle, Selector.GetHandle ("initWithImage:cropFrame:angle:"), image.Handle, cropFrame, angle), "initWithImage:cropFrame:angle:");
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Angle {
			[Export ("angle")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("angle"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("angle"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGRect CropFrame {
			[Export ("cropFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("cropFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropFrame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropFrame"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage Image {
			[Export ("image")]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("image")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("image")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Image_var = null;
			}
		}
	} /* class TOActivityCroppedImageProvider */
}

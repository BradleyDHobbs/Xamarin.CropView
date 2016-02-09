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
	[Register("TOCropOverlayView", true)]
	public unsafe partial class TOCropOverlayView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TOCropOverlayView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TOCropOverlayView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public TOCropOverlayView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected TOCropOverlayView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TOCropOverlayView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setGridHidden:animated:")]
		[CompilerGenerated]
		public virtual void SetGridHidden (bool hidden, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setGridHidden:animated:"), hidden, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setGridHidden:animated:"), hidden, animated);
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisplayHorizontalGridLines {
			[Export ("displayHorizontalGridLines")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayHorizontalGridLines"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayHorizontalGridLines"));
				}
			}
			
			[Export ("setDisplayHorizontalGridLines:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisplayHorizontalGridLines:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisplayHorizontalGridLines:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisplayVerticalGridLines {
			[Export ("displayVerticalGridLines")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayVerticalGridLines"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayVerticalGridLines"));
				}
			}
			
			[Export ("setDisplayVerticalGridLines:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisplayVerticalGridLines:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisplayVerticalGridLines:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool GridHidden {
			[Export ("gridHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("gridHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gridHidden"));
				}
			}
			
			[Export ("setGridHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setGridHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setGridHidden:"), value);
				}
			}
		}
		
		public partial class TOCropOverlayViewAppearance : UIView.UIViewAppearance {
			protected internal TOCropOverlayViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new TOCropOverlayViewAppearance Appearance {
			get { return new TOCropOverlayViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new TOCropOverlayViewAppearance GetAppearance<T> () where T: TOCropOverlayView {
			return new TOCropOverlayViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new TOCropOverlayViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new TOCropOverlayViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new TOCropOverlayViewAppearance GetAppearance (UITraitCollection traits) {
			return new TOCropOverlayViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new TOCropOverlayViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new TOCropOverlayViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new TOCropOverlayViewAppearance GetAppearance<T> (UITraitCollection traits) where T: TOCropOverlayView {
			return new TOCropOverlayViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new TOCropOverlayViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: TOCropOverlayView{
			return new TOCropOverlayViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class TOCropOverlayView */
}

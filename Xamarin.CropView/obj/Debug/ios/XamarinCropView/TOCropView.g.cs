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
	[Register("TOCropView", true)]
	public unsafe partial class TOCropView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TOCropView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TOCropView () : base (NSObjectFlag.Empty)
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
		public TOCropView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected TOCropView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TOCropView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithImage:")]
		[CompilerGenerated]
		public TOCropView (global::UIKit.UIImage image)
			: base (NSObjectFlag.Empty)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithImage:"), image.Handle), "initWithImage:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithImage:"), image.Handle), "initWithImage:");
			}
		}
		
		[Export ("performRelayoutForRotation")]
		[CompilerGenerated]
		public virtual void PerformRelayoutForRotation ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("performRelayoutForRotation"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("performRelayoutForRotation"));
			}
		}
		
		[Export ("prepareforRotation")]
		[CompilerGenerated]
		public virtual void PrepareforRotation ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareforRotation"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prepareforRotation"));
			}
		}
		
		[Export ("resetLayoutToDefaultAnimated:")]
		[CompilerGenerated]
		public virtual void ResetLayoutToDefaultAnimated (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("resetLayoutToDefaultAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("resetLayoutToDefaultAnimated:"), animated);
			}
		}
		
		[Export ("rotateImageNinetyDegreesAnimated:")]
		[CompilerGenerated]
		public virtual void RotateImageNinetyDegreesAnimated (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("rotateImageNinetyDegreesAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("rotateImageNinetyDegreesAnimated:"), animated);
			}
		}
		
		[Export ("rotateImageNinetyDegreesAnimated:clockwise:")]
		[CompilerGenerated]
		public virtual void RotateImageNinetyDegreesAnimated (bool animated, bool clockwise)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("rotateImageNinetyDegreesAnimated:clockwise:"), animated, clockwise);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("rotateImageNinetyDegreesAnimated:clockwise:"), animated, clockwise);
			}
		}
		
		[Export ("setAspectLockEnabledWithAspectRatio:animated:")]
		[CompilerGenerated]
		public virtual void SetAspectLockEnabledWithAspectRatio (CGSize aspectRatio, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGSize_bool (this.Handle, Selector.GetHandle ("setAspectLockEnabledWithAspectRatio:animated:"), aspectRatio, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize_bool (this.SuperHandle, Selector.GetHandle ("setAspectLockEnabledWithAspectRatio:animated:"), aspectRatio, animated);
			}
		}
		
		[Export ("setCroppingViewsHidden:animated:")]
		[CompilerGenerated]
		public virtual void SetCroppingViewsHidden (bool hidden, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setCroppingViewsHidden:animated:"), hidden, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setCroppingViewsHidden:animated:"), hidden, animated);
			}
		}
		
		[Export ("setGridOverlayHidden:animated:")]
		[CompilerGenerated]
		public virtual void SetGridOverlayHidden (bool gridOverlayHidden, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setGridOverlayHidden:animated:"), gridOverlayHidden, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setGridOverlayHidden:animated:"), gridOverlayHidden, animated);
			}
		}
		
		[Export ("setSimpleMode:animated:")]
		[CompilerGenerated]
		public virtual void SetSimpleMode (bool simpleMode, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setSimpleMode:animated:"), simpleMode, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setSimpleMode:animated:"), simpleMode, animated);
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
		public virtual bool AspectRatioLocked {
			[Export ("aspectRatioLocked")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("aspectRatioLocked"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("aspectRatioLocked"));
				}
			}
			
			[Export ("setAspectRatioLocked:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAspectRatioLocked:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAspectRatioLocked:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool CanReset {
			[Export ("canReset")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canReset"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canReset"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CropBoxAspectRatioIsPortrait {
			[Export ("cropBoxAspectRatioIsPortrait")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cropBoxAspectRatioIsPortrait"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropBoxAspectRatioIsPortrait"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CGRect CropBoxFrame {
			[Export ("cropBoxFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("cropBoxFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropBoxFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropBoxFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropBoxFrame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropBoxFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropBoxFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropBoxFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropBoxFrame"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CropBoxResizeEnabled {
			[Export ("cropBoxResizeEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cropBoxResizeEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropBoxResizeEnabled"));
				}
			}
			
			[Export ("setCropBoxResizeEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCropBoxResizeEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCropBoxResizeEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual CGRect CroppedImageFrame {
			[Export ("croppedImageFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("croppedImageFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("croppedImageFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("croppedImageFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("croppedImageFrame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("croppedImageFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("croppedImageFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("croppedImageFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("croppedImageFrame"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CroppingViewsHidden {
			[Export ("croppingViewsHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("croppingViewsHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("croppingViewsHidden"));
				}
			}
			
			[Export ("setCroppingViewsHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCroppingViewsHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCroppingViewsHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIEdgeInsets CropRegionInsets {
			[Export ("cropRegionInsets", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIEdgeInsets ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend (this.Handle, Selector.GetHandle ("cropRegionInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropRegionInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropRegionInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("cropRegionInsets"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropRegionInsets"));
						} else {
							global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropRegionInsets"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropRegionInsets"));
					} else {
						global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("cropRegionInsets"));
					}
				}
				return ret;
			}
			
			[Export ("setCropRegionInsets:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("setCropRegionInsets:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("setCropRegionInsets:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public TOCropViewDelegate Delegate {
			get {
				return WeakDelegate as /**/TOCropViewDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool GridOverlayHidden {
			[Export ("gridOverlayHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("gridOverlayHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gridOverlayHidden"));
				}
			}
			
			[Export ("setGridOverlayHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setGridOverlayHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setGridOverlayHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_GridOverlayView_var;
		[CompilerGenerated]
		public virtual TOCropOverlayView GridOverlayView {
			[Export ("gridOverlayView", ArgumentSemantic.Retain)]
			get {
				TOCropOverlayView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TOCropOverlayView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gridOverlayView")));
				} else {
					ret =  Runtime.GetNSObject<TOCropOverlayView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gridOverlayView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_GridOverlayView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage Image {
			[Export ("image", ArgumentSemantic.Retain)]
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
		public virtual CGRect ImageViewFrame {
			[Export ("imageViewFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("imageViewFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("imageViewFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("imageViewFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("imageViewFrame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("imageViewFrame"));
						} else {
							global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("imageViewFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("imageViewFrame"));
					} else {
						global::ApiDefinition.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("imageViewFrame"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool SimpleMode {
			[Export ("simpleMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("simpleMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("simpleMode"));
				}
			}
			
			[Export ("setSimpleMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSimpleMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSimpleMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_GridOverlayView_var = null;
				__mt_Image_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class TOCropViewAppearance : UIView.UIViewAppearance {
			protected internal TOCropViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new TOCropViewAppearance Appearance {
			get { return new TOCropViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new TOCropViewAppearance GetAppearance<T> () where T: TOCropView {
			return new TOCropViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new TOCropViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new TOCropViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new TOCropViewAppearance GetAppearance (UITraitCollection traits) {
			return new TOCropViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new TOCropViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new TOCropViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new TOCropViewAppearance GetAppearance<T> (UITraitCollection traits) where T: TOCropView {
			return new TOCropViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new TOCropViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: TOCropView{
			return new TOCropViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class TOCropView */
}

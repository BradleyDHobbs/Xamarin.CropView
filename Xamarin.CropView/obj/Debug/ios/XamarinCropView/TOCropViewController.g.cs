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
	[Register("TOCropViewController", true)]
	public unsafe partial class TOCropViewController : global::UIKit.UIViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TOCropViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TOCropViewController () : base (NSObjectFlag.Empty)
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
		public TOCropViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected TOCropViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TOCropViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithImage:")]
		[CompilerGenerated]
		public TOCropViewController (global::UIKit.UIImage image)
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
		
		[Export ("dismissAnimatedFromParentViewController:withCroppedImage:toFrame:completion:")]
		[CompilerGenerated]
		public unsafe virtual void DismissAnimatedFromParentViewController (global::UIKit.UIViewController viewController, global::UIKit.UIImage image, CGRect frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.SDAction))]global::System.Action completion)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr (this.Handle, Selector.GetHandle ("dismissAnimatedFromParentViewController:withCroppedImage:toFrame:completion:"), viewController.Handle, image.Handle, frame, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("dismissAnimatedFromParentViewController:withCroppedImage:toFrame:completion:"), viewController.Handle, image.Handle, frame, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("dismissAnimatedFromParentViewController:toFrame:completion:")]
		[CompilerGenerated]
		public unsafe virtual void DismissAnimatedFromParentViewController (global::UIKit.UIViewController viewController, CGRect frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.SDAction))]global::System.Action completion)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr (this.Handle, Selector.GetHandle ("dismissAnimatedFromParentViewController:toFrame:completion:"), viewController.Handle, frame, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("dismissAnimatedFromParentViewController:toFrame:completion:"), viewController.Handle, frame, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("presentAnimatedFromParentViewController:fromFrame:completion:")]
		[CompilerGenerated]
		public unsafe virtual void PresentAnimatedFromParentViewController (global::UIKit.UIViewController viewController, CGRect frame, [BlockProxy (typeof (ObjCRuntime.Trampolines.SDAction))]global::System.Action completion)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr (this.Handle, Selector.GetHandle ("presentAnimatedFromParentViewController:fromFrame:completion:"), viewController.Handle, frame, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("presentAnimatedFromParentViewController:fromFrame:completion:"), viewController.Handle, frame, (IntPtr) block_ptr_completion);
			}
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_ActivityItems_var;
		[CompilerGenerated]
		public virtual NSObject[] ActivityItems {
			[Export ("activityItems", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("activityItems")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("activityItems")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ActivityItems_var = ret;
				return ret;
			}
			
			[Export ("setActivityItems:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActivityItems:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setActivityItems:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ActivityItems_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ApplicationActivities_var;
		[CompilerGenerated]
		public virtual NSObject[] ApplicationActivities {
			[Export ("applicationActivities", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applicationActivities")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationActivities")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ApplicationActivities_var = ret;
				return ret;
			}
			
			[Export ("setApplicationActivities:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setApplicationActivities:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setApplicationActivities:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ApplicationActivities_var = value;
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
		object __mt_CropView_var;
		[CompilerGenerated]
		public virtual TOCropView CropView {
			[Export ("cropView", ArgumentSemantic.Retain)]
			get {
				TOCropView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TOCropView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cropView")));
				} else {
					ret =  Runtime.GetNSObject<TOCropView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CropView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual TOCropViewControllerAspectRatio DefaultAspectRatio {
			[Export ("defaultAspectRatio", ArgumentSemantic.UnsafeUnretained)]
			get {
				TOCropViewControllerAspectRatio ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (TOCropViewControllerAspectRatio) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("defaultAspectRatio"));
					} else {
						ret = (TOCropViewControllerAspectRatio) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("defaultAspectRatio"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (TOCropViewControllerAspectRatio) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultAspectRatio"));
					} else {
						ret = (TOCropViewControllerAspectRatio) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultAspectRatio"));
					}
				}
				return ret;
			}
			
			[Export ("setDefaultAspectRatio:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setDefaultAspectRatio:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDefaultAspectRatio:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setDefaultAspectRatio:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDefaultAspectRatio:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public TOCropViewControllerDelegate Delegate {
			get {
				return WeakDelegate as /**/TOCropViewControllerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ExcludedActivityTypes_var;
		[CompilerGenerated]
		public virtual NSObject[] ExcludedActivityTypes {
			[Export ("excludedActivityTypes", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("excludedActivityTypes")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("excludedActivityTypes")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivityTypes_var = ret;
				return ret;
			}
			
			[Export ("setExcludedActivityTypes:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExcludedActivityTypes:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExcludedActivityTypes:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ExcludedActivityTypes_var = value;
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
		public unsafe virtual global::System.Action PrepareForTransitionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAction))]
			[Export ("prepareForTransitionHandler", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("prepareForTransitionHandler"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prepareForTransitionHandler"));
				}
				return global::ObjCRuntime.Trampolines.NIDAction.Create (ret);
			}
			
			[Export ("setPrepareForTransitionHandler:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlock (Trampolines.SDAction.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPrepareForTransitionHandler:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPrepareForTransitionHandler:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool RotateButtonsHidden {
			[Export ("rotateButtonsHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("rotateButtonsHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotateButtonsHidden"));
				}
			}
			
			[Export ("setRotateButtonsHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotateButtonsHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRotateButtonsHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RotateClockwiseButtonHidden {
			[Export ("rotateClockwiseButtonHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("rotateClockwiseButtonHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotateClockwiseButtonHidden"));
				}
			}
			
			[Export ("setRotateClockwiseButtonHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotateClockwiseButtonHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRotateClockwiseButtonHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowActivitySheetOnDone {
			[Export ("showActivitySheetOnDone")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showActivitySheetOnDone"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showActivitySheetOnDone"));
				}
			}
			
			[Export ("setShowActivitySheetOnDone:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowActivitySheetOnDone:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowActivitySheetOnDone:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Toolbar_var;
		[CompilerGenerated]
		public virtual TOCropToolbar Toolbar {
			[Export ("toolbar", ArgumentSemantic.Retain)]
			get {
				TOCropToolbar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TOCropToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("toolbar")));
				} else {
					ret =  Runtime.GetNSObject<TOCropToolbar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toolbar")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Toolbar_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual TOCropViewControllerToolbarPosition ToolbarPosition {
			[Export ("toolbarPosition", ArgumentSemantic.UnsafeUnretained)]
			get {
				TOCropViewControllerToolbarPosition ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (TOCropViewControllerToolbarPosition) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarPosition"));
					} else {
						ret = (TOCropViewControllerToolbarPosition) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarPosition"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (TOCropViewControllerToolbarPosition) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toolbarPosition"));
					} else {
						ret = (TOCropViewControllerToolbarPosition) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toolbarPosition"));
					}
				}
				return ret;
			}
			
			[Export ("setToolbarPosition:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setToolbarPosition:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setToolbarPosition:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setToolbarPosition:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setToolbarPosition:"), (int)value);
					}
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
				__mt_ActivityItems_var = null;
				__mt_ApplicationActivities_var = null;
				__mt_CropView_var = null;
				__mt_ExcludedActivityTypes_var = null;
				__mt_Image_var = null;
				__mt_Toolbar_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class TOCropViewController */
}

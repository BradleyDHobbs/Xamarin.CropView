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
	[Protocol (Name = "TOCropViewDelegate", WrapperType = typeof (TOCropViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CropViewDidBecomeResettable", Selector = "cropViewDidBecomeResettable:", ParameterType = new Type [] { typeof (Xamarin.CropView.TOCropView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CropViewDidBecomeNonResettable", Selector = "cropViewDidBecomeNonResettable:", ParameterType = new Type [] { typeof (Xamarin.CropView.TOCropView) }, ParameterByRef = new bool [] { false })]
	public interface ITOCropViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("cropViewDidBecomeResettable:")]
		[Preserve (Conditional = true)]
		void CropViewDidBecomeResettable (TOCropView cropView);
		
		[CompilerGenerated]
		[Export ("cropViewDidBecomeNonResettable:")]
		[Preserve (Conditional = true)]
		void CropViewDidBecomeNonResettable (TOCropView cropView);
		
	}
	
	internal sealed class TOCropViewDelegateWrapper : BaseWrapper, ITOCropViewDelegate {
		public TOCropViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public TOCropViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("cropViewDidBecomeResettable:")]
		[CompilerGenerated]
		public void CropViewDidBecomeResettable (TOCropView cropView)
		{
			if (cropView == null)
				throw new ArgumentNullException ("cropView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cropViewDidBecomeResettable:"), cropView.Handle);
		}
		
		[Export ("cropViewDidBecomeNonResettable:")]
		[CompilerGenerated]
		public void CropViewDidBecomeNonResettable (TOCropView cropView)
		{
			if (cropView == null)
				throw new ArgumentNullException ("cropView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cropViewDidBecomeNonResettable:"), cropView.Handle);
		}
		
	}
}
namespace Xamarin.CropView {
	[Protocol]
	[Register("TOCropViewDelegate", false)]
	[Model]
	public unsafe abstract partial class TOCropViewDelegate : NSObject, ITOCropViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected TOCropViewDelegate () : base (NSObjectFlag.Empty)
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
		protected TOCropViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TOCropViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cropViewDidBecomeNonResettable:")]
		[CompilerGenerated]
		public abstract void CropViewDidBecomeNonResettable (TOCropView cropView);
		[Export ("cropViewDidBecomeResettable:")]
		[CompilerGenerated]
		public abstract void CropViewDidBecomeResettable (TOCropView cropView);
	} /* class TOCropViewDelegate */
}

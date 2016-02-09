using System;

using Xamarin.Forms;

namespace Xamarin.CropViewSample
{
	public class App : Application
	{
		public static byte[] CroppedImage;
		static NavigationPage NavigationStack;

		public App ()
		{
			// The root page of your application
			NavigationStack = new NavigationPage(new MainPage());
			MainPage = NavigationStack;
		}

		public static Action PopModal
		{
			get {
				return new Action(() => {
					NavigationStack.Navigation.PopModalAsync();
				});
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


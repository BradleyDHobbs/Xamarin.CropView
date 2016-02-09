using System;
using Xamarin.Forms;
using XLabs.Platform.Services.Media;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

namespace Xamarin.CropViewSample
{
	public class MainPage : ContentPage
	{
		ImageSource _imageSource;
		private IMediaPicker _mediaPicker;
		Image image;

		public MainPage ()
		{
			Title = "Crop View";
			NavigationPage.SetHasNavigationBar (this, true);
			ToolbarItems.Add (new ToolbarItem () {
				Icon = "Plus Math-50@2x.png",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(async (x) => {
					var action = await DisplayActionSheet (null, "Cancel", null, "Photo Library", "Take Photo");
					if (action == "Photo Library")
						await SelectPicture();
					else if (action == "Take Photo")
						await TakePicture();
					else if (action == "Cancel")
						return;
				}), 
			});

			image = new Image {
				Aspect = Aspect.AspectFit,
			};

			Label label = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				Text = "Select an image to crop",
				TextColor = Color.Black
			};

			Content = label;
		}

		private void Refresh() 
		{
			try 
			{
				if (App.CroppedImage != null) 
				{
					Stream stream = new MemoryStream (App.CroppedImage);
					image.Source = ImageSource.FromStream (() => stream);

					Content = image;
				}
			}
			catch (Exception ex) {
				Debug.WriteLine (ex.Message);
			}
		}

		#region Photos

		private void Setup()
		{
			if (_mediaPicker != null)
			{
				return;
			}

			////RM: hack for working on windows phone? 
			_mediaPicker = DependencyService.Get<IMediaPicker>();
		}

		private async Task SelectPicture()
		{
			Setup();

			_imageSource = null;

			try
			{

				var mediaFile = await this._mediaPicker.SelectPhotoAsync(new CameraMediaStorageOptions
					{
						DefaultCamera = CameraDevice.Front,
						MaxPixelDimension = 500
					});

				_imageSource = ImageSource.FromStream(() => mediaFile.Source);

				var memoryStream = new MemoryStream();
				await mediaFile.Source.CopyToAsync(memoryStream);
				byte[] imageAsByte = memoryStream.ToArray();

				if (Device.OS == TargetPlatform.iOS) {
					await Navigation.PushModalAsync(new CropView(imageAsByte, Refresh));
				}
			}
			catch (System.Exception ex)
			{
				Debug.WriteLine (ex.Message);
			}
		}

		private async Task TakePicture()
		{
			Setup();

			_imageSource = null;

			try 
			{
				var mediaFile = await this._mediaPicker.TakePhotoAsync (new CameraMediaStorageOptions {
					DefaultCamera = CameraDevice.Front,
					MaxPixelDimension = 500
				});

				_imageSource = ImageSource.FromStream(() => mediaFile.Source);

				var memoryStream = new MemoryStream();
				await mediaFile.Source.CopyToAsync(memoryStream);
				byte[] imageAsByte = memoryStream.ToArray();

				if (Device.OS == TargetPlatform.iOS) {
					await Navigation.PushModalAsync(new CropView(imageAsByte, Refresh));
				}
			}
			catch (Exception ex) 
			{
				Debug.WriteLine (ex.Message);
			}
		}

		#endregion
	}

}


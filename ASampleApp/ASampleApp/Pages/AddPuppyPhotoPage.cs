using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace ASampleApp
{
    public class AddPuppyPhotoPage : BaseContentPage<AddPhotoPhotoViewModel>
	{

        Button _takePhoto;
        Image _dogImage;

		public AddPuppyPhotoPage ()
		{
            _takePhoto = new Button() {Text = "Take Photo"};
            _dogImage = new Image();

            Content = new StackLayout()
            {
                Children = {
                    _takePhoto,
                    _dogImage


                }

            };



			_takePhoto.Clicked += async (sender, args) =>
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
        {
            DisplayAlert("No Camera", ":( No camera available.", "OK");
            return;
        }

        var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
        {
            Directory = "Sample",
            Name = "test.jpg"
        });

        if (file == null)
        return;

        await DisplayAlert("File Location", file.Path, "OK");

       _dogImage.Source = ImageSource.FromStream(() =>
        {
            var stream = file.GetStream();
            file.Dispose();
            return stream;
        });

        //or:
        //image.Source = ImageSource.FromFile(file.Path);
        //image.Dispose();
        };



        }




	}
}

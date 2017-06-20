using System;

using Xamarin.Forms;

namespace ASampleApp
{
	public class App : Application
	{
		public App ()
		{
			var asp = new FirstPage ();

			//// The root page of your application
			//var content = new ContentPage {
			//	Title = "ASampleApp",
			//	Content = new StackLayout {
			//		VerticalOptions = LayoutOptions.Center,
			//		Children = {
			//			new Label {
			//				HorizontalTextAlignment = TextAlignment.Center,
			//				Text = "Welcome to Xamarin Forms!"
			//			}
			//		}
			//	}
			//};

			MainPage = new NavigationPage (asp);
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

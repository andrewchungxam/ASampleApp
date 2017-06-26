using System;
using Xamarin.Forms;
namespace ASampleApp
{
	public class FirstPage : BaseContentPage<FirstViewModel>
	{
		Label _firstLabel;
		Entry _firstEntry;
		Button _firstButton;
		Button _goToDogList;

		public FirstPage ()
		{

			//BindingContext = new FirstViewModel ();

			//METHOD#1 non-MVVM
			//
			_firstLabel = new Label (); //{ Text = "Hello"};
			_firstEntry = new Entry ();
			_firstButton = new Button () { Text = "Button" };
			_goToDogList = new Button () { Text = "Go to Dog List" };
			//METHOD#2 MVVM
			//
			_firstLabel.SetBinding (Label.TextProperty, nameof (MyViewModel.FirstLabel));
			_firstEntry.SetBinding (Entry.TextProperty, nameof (MyViewModel.FirstEntryText));
			_firstButton.SetBinding (Button.CommandProperty, nameof (MyViewModel.MyFavoriteCommand));


			Content = new StackLayout {
				Margin = 20,
				Children =
				{
					_firstLabel,
					_firstEntry,
					_firstButton,
					_goToDogList

				}

			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			//METHOD 1
			//			_firstButton.Clicked += OnFirstButtonClicked;

			_goToDogList.Clicked += OnToDogListClicked;

			//TEST BY ADDING DOGS ON EACH ONAPPEARING
			//App.DogRep.AddNewDog("Oliver", "Black");
			//App.DogRep.AddNewDog("Oliver", "Black");


		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			//METHOD 1

			//			_firstButton.Clicked -= OnFirstButtonClicked;

			_goToDogList.Clicked -= OnToDogListClicked;
		}

		void OnToDogListClicked (object sender, EventArgs e)
		{
			//OPTION 1
			//Device.BeginInvokeOnMainThread (() => Navigation.PushAsync (new DogListPage ()));

			//OPTION 2
			Device.BeginInvokeOnMainThread (() => Navigation.PushAsync (new DogListMVVMPage ()));
		}



		//EventHandler OnToDogListClicked ()
		//{
		//	//throw new NotImplementedException ();
		//	Device.BeginInvokeOnMainThread (()=> Navigation.PushAsync (new DogListPage()));
		//}

		//void OnFirstButtonClicked (object sender, EventArgs e)
		//{
		//	Console.WriteLine ("Hello there;");
		//	string ft = _firstEntry.Text;

		//	//SIMPLE ACTION 1
		//	//Device.BeginInvokeOnMainThread (() => 
		//	//                                _firstLabel.Text = ft
		//	//                               );

		//	//SIMPLE ACTION 2
		//	//ViewModel.FirstLabel = "hi there!";

		//}
	}
}

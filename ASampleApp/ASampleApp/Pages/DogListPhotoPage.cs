﻿using System;
using Xamarin.Forms;

namespace ASampleApp
{
    public class DogListPhotoPage : BaseContentPage<DogListPhotoViewModel>
	{
		Label _firstLabel;
		Entry _firstEntry;
		Entry _secondEntry;
		Button _firstButton;
		Button _goToDogListButton;

		Button _addAddDogPhotoURLButton;
		Button _addAddDogPhotoButton;
		Button _goToDogPhotoListButton;


		public DogListPhotoPage ()
		{

			this.Title = "Dog List Photo Page";


			//METHOD#1 non-MVVM
			//BindingContext = new FirstViewModel();

			_firstLabel = new Label(); //{ Text = "Hello"};
			_firstEntry = new Entry() { Placeholder = "Dog Name" };
			_secondEntry = new Entry() { Placeholder = "Fur color" };
			_firstButton = new Button() { Text = "Button" };
			_goToDogListButton = new Button() { Text = "Go to Dog List" };

			_addAddDogPhotoButton = new Button() { Text = "Add Dog Photo" };
			_addAddDogPhotoURLButton = new Button { Text = "Add Dog Photo URL" };
			_goToDogPhotoListButton = new Button() { Text = "Go to Dog Photo List" };


			//METHOD#2 MVVM
			//
			_firstLabel.SetBinding(Label.TextProperty, nameof(MyViewModel.FirstLabel), BindingMode.TwoWay);
			_firstEntry.SetBinding(Entry.TextProperty, nameof(MyViewModel.FirstEntryText));
			_secondEntry.SetBinding(Entry.TextProperty, nameof(MyViewModel.SecondEntryText));

			_firstButton.SetBinding(Button.CommandProperty, nameof(MyViewModel.MyFavoriteCommand));


			Content = new StackLayout
			{
				Margin = 20,
				Children =
				{
					_firstLabel,
					_firstEntry,
					_secondEntry,
					_firstButton,
					_goToDogListButton,
					_addAddDogPhotoButton,
					_addAddDogPhotoURLButton,
					_goToDogPhotoListButton

				}

			};

		}



		protected override void OnAppearing()
		{
			base.OnAppearing();
			//METHOD 1
			//          _firstButton.Clicked += OnFirstButtonClicked;

			_goToDogListButton.Clicked += OnToDogListClicked;

			//TEST BY ADDING DOGS ON EACH ONAPPEARING
			//App.DogRep.AddNewDog("Oliver", "Black");
			//App.DogRep.AddNewDog("Oliver", "Black");


		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			//METHOD 1

			//          _firstButton.Clicked -= OnFirstButtonClicked;

			_goToDogListButton.Clicked -= OnToDogListClicked;
		}

		void OnToDogListClicked(object sender, EventArgs e)
		{
			//OPTION 1
			//Device.BeginInvokeOnMainThread (() => Navigation.PushAsync (new DogListPage ()));

			//OPTION 2
			Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(new DogListMVVMPage()));
		}



		//EventHandler OnToDogListClicked ()
		//{
		//  //throw new NotImplementedException ();
		//  Device.BeginInvokeOnMainThread (()=> Navigation.PushAsync (new DogListPage()));
		//}

		//void OnFirstButtonClicked (object sender, EventArgs e)
		//{
		//  Console.WriteLine ("Hello there;");
		//  string ft = _firstEntry.Text;

		//  //SIMPLE ACTION 1
		//  //Device.BeginInvokeOnMainThread (() => 
		//  //                                _firstLabel.Text = ft
		//  //                               );

		//  //SIMPLE ACTION 2
		//  //ViewModel.FirstLabel = "hi there!";

		//}
	}
}


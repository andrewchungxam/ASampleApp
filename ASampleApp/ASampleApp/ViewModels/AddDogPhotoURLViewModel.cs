using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ASampleApp
{
	public class AddDogPhotoURLViewModel : BaseViewModel
	{
		string _firstLabel;
		string _firstEntryText;
		string _secondEntryText;

		public ICommand MyFavoriteCommand { get; set; }
		public ICommand MySecondFavoriteCommand { get; set;}

		public string FirstLabel
		{
			get { return _firstLabel;}
			set { SetProperty (ref _firstLabel, value);}
		}

		public string FirstEntryText
		{
			get { return _firstEntryText;}
			set { SetProperty (ref _firstEntryText, value);}

		}

		public string SecondEntryText
		{
			get { return _secondEntryText;}
			set { SetProperty (ref _secondEntryText, value);}
		}

		public AddDogPhotoURLViewModel ()
		{
			MyFavoriteCommand = new Command (OnMyFavoriteAction);
		}

		void OnMyFavoriteAction ()
		{
            App.DogRep.AddNewDog(this.FirstEntryText, this.SecondEntryText);
            string _lastNameString = App.DogRep.GetLastDog().Name;

            string _lastNameStringAdd = System.String.Format("{0} added to the list!", _lastNameString);
            this.FirstLabel = _lastNameStringAdd;

            return;		
		}
	}
}

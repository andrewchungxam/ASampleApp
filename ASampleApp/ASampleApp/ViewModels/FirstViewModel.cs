using System;
using Xamarin.Forms;
namespace ASampleApp
{
	public class FirstViewModel : BaseViewModel
	{

		string _firstLabel;
		string _firstEntryText;

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

		public FirstViewModel ()
		{
		}


	}
}

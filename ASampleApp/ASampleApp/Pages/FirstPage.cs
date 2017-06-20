using System;
using Xamarin.Forms;
namespace ASampleApp
{
	public class FirstPage : BaseContentPage<FirstViewModel>
	{
		Label _firstLabel;
		Entry _firstEntry;
		Button _firstButton;

		public FirstPage ()
		{

			//BindingContext = new FirstViewModel ();

			//METHOD#1 non-MVVM
			//
			_firstLabel = new Label (); //{ Text = "Hello"};
			_firstEntry = new Entry ();
			_firstButton = new Button () { Text = "Button"};

			//METHOD#2 MVVM
			//
			_firstLabel.SetBinding (Label.TextProperty, nameof(ViewModel.FirstLabel));
			_firstEntry.SetBinding (Entry.TextProperty, nameof (ViewModel.FirstEntryText));
			           
			Content = new StackLayout 
			{
				Margin = 20,
				Children =
				{
					_firstLabel,
					_firstEntry,
					_firstButton

				}

			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			_firstButton.Clicked += OnFirstButtonClicked;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			_firstButton.Clicked -= OnFirstButtonClicked;
		}

		void OnFirstButtonClicked (object sender, EventArgs e)
		{
			Console.WriteLine ("Hello there;");
			string ft = _firstEntry.Text;

			//SIMPLE COMMAND 1
			//Device.BeginInvokeOnMainThread (() => 
			//                                _firstLabel.Text = ft
			//                               );

			//SIMPLE COMMAND 2
			ViewModel.FirstLabel = "hi there!";

		}
	}
}

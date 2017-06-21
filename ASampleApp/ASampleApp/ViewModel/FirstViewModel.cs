using System;
using System.Windows.Input;
using Xamarin.Forms;
namespace ASampleApp.ViewModel
{
    public class FirstViewModel : BaseViewModel
    {
        string _displayItem, _firstItem;

        public ICommand DisplayItemCommand { get; set; }

        public string DisplayItem
        {
            get { return _displayItem; }
            set { SetProperty(ref _displayItem, value); }

        }

        public string FirstItem
        {
            get { return _firstItem; }
            set { SetProperty(ref _firstItem, value); }
        }

        public FirstViewModel(){
            DisplayItemCommand = new Command(HandleAction);
        }

        void HandleAction(object obj)
        {
			this.DisplayItem = "The Barlow";
        }
    }
}
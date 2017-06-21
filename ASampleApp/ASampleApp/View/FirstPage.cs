using System;

using Xamarin.Forms;
using ASampleApp.ViewModel;
using ASampleApp.Data;
using SQLite;

namespace ASampleApp.View
{
    public class FirstPage : ContentPage
    {
        Label _displayItem = new Label(); //{ Text = "Label" };
        Entry _firstItem = new Entry { Placeholder = "Enter Value" };
        Button _submitButton = new Button { Text = "Submit" };
        FirstViewModel _firstViewModel;
        Label _dbPath = new Label() { Text = FileAccessHelper.GetLocalFilePath("people.db3") };
        Label _dogLabel = new Label() { Text = App.DogRepo.GetFirstDog().Name };

        public FirstPage()
        {
            _firstViewModel = new FirstViewModel();
            BindingContext = _firstViewModel;

            _displayItem.SetBinding(Label.TextProperty, "DisplayItem");
            _firstItem.SetBinding(Entry.TextProperty, "FirstItem");
            _submitButton.SetBinding(Button.CommandProperty, "DisplayItemCommand");

            Content = new StackLayout
            {
                Margin = 20,
                Children = {
                    _displayItem,
                    _dogLabel,
                    _firstItem,
                    _submitButton,
                    _dbPath
                }
            };

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

    }
}


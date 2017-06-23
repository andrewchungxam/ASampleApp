using System;
using Xamarin.Forms;
using ASampleApp.Data;
using ASampleApp.Helper;
namespace ASampleApp.View
{
    public class ListOfDogsPage : ContentPage
    {
        ListView _dogList;
        ///var _cellColor;

        public ListOfDogsPage()
        {
            _dogList = new ListView();
            _dogList.ItemsSource = App.DogRepo.GetAllDogs();
            //_cellColor = ;

            var myTemplate = new DataTemplate(typeof(DogViewCell));
			//myTemplate.SetBinding(DogViewCell.BindingContextProperty, "Name");
			//myTemplate.SetBinding(DogViewCell.DetailProperty, "FurColor");
			//myTemplate.SetBinding(DogViewCell.TextColorProperty, "FurColorHexColor");
            myTemplate.SetBinding(DogViewCell.BindingContextProperty, "Name");
            myTemplate.SetBinding(DogViewCell.BindingContextProperty, "FurColor");
            myTemplate.SetBinding(DogViewCell.BindingContextProperty, "FurColorHexColor");

            _dogList.ItemTemplate = myTemplate;

            Content = new StackLayout
            {
				Margin = 20,
                Children = { 
                    _dogList
                }
            };
        }
    }
}

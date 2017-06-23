using System;
using Xamarin.Forms;
using System.Security.Cryptography.X509Certificates;
namespace ASampleApp.Helper
{
    public class DogViewCell : ViewCell
    {


        public DogViewCell()
        {
            //var _myImage = new Image();
            var _myDoggoName = new Label();
            var _myDoggoFurColor = new Label();
            var _myHorizontalLayout = new StackLayout(){
                Children = {
                    _myDoggoName,
                    _myDoggoFurColor
                }
            };

            //_myImage.SetBinding();


            View = _myHorizontalLayout;
        }
    }
}

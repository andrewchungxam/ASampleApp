using System;
using Xamarin.Forms;
namespace ASampleApp
{
	public abstract class BaseContentPage<T>: ContentPage where T: BaseViewModel, new() 
	{

		T _viewModel;

		public BaseContentPage ()
		{
			BindingContext = ViewModel;
		}

		//protected T ViewModel => _viewModel ?? (_viewModel = new T ());
		protected T ViewModel {
			get 
			{
				return _viewModel ?? (_viewModel = new T ());
			}
		}
	}
}



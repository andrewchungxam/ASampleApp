using System;
using System.Collections.Generic;
using ASampleApp.Models;
namespace ASampleApp
{
	public class DogListViewModel : BaseViewModel
	{

		IList<Dog> _listOfDogs;

		public IList<Dog> ListOfDogs 
		{
			get { return _listOfDogs;}
			set { SetProperty (ref _listOfDogs, value);}
		}



	}
}

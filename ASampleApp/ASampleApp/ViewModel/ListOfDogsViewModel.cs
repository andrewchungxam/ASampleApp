using System;
using System.Collections;
using System.Collections.Generic;
using ASampleApp.Data;

namespace ASampleApp.ViewModel
{
    public class ListOfDogsViewModel : BaseViewModel
    {
        IList<Dog> _listOfDoggos;

        public ListOfDogsViewModel()
        {
        }

        public IList<Dog> ListOfDoggos
        {
            get { return _listOfDoggos; }
            set { SetProperty(ref _listOfDoggos, value); }
        }
    }
}

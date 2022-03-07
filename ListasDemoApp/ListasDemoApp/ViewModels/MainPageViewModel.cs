using ListasDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ListasDemoApp.ViewModels
{
    public class MainPageViewModel
    {
        //public List<Friend> Friends { get; set; }
        public ObservableCollection<Helpers.Grouping<string, Friend>> Friends { get; set; }

        public MainPageViewModel()
        {
            FriendRepository repository = new FriendRepository();
            //Friends = repository.GetAll().ToList();
            Friends = repository.GetAllGrouped();
        }
    }
}

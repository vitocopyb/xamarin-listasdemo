using ListasDemoApp.Helpers;
using ListasDemoApp.Models;
using ListasDemoApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListasDemoApp.ViewModels
{
    //public class MainPageViewModel : INotifyPropertyChanged
    public class MainPageViewModel : ViewModelBase
    {
        private Friend currentFriend;

        //public List<Friend> Friends { get; set; }
        public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }
        private INavigation Navigation { get; set; }
        public Command AddFriendCommand { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command DeleteFriendCommand { get; set; }
        public Friend CurrentFriend
        {
            get => currentFriend;
            set
            {
                currentFriend = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel(INavigation navigation)
        {
            FriendRepository repository = new FriendRepository();
            //Friends = repository.GetAll().ToList();
            Friends = repository.GetAllGrouped();
            Navigation = navigation;
            AddFriendCommand = new Command(async () => await NavigateToFriendPage());
            ItemTappedCommand = new Command(async () => await NavigateToEditFriendPage());
        }

        private async Task NavigateToEditFriendPage()
        {
            await Navigation.PushAsync(new FriendPage(CurrentFriend));
        }

        private async Task NavigateToFriendPage()
        {
            await Navigation.PushAsync(new FriendPage());
        }

        //#region PropertyChanged
        //public event PropertyChangedEventHandler PropertyChanged;

        //// Create the OnPropertyChanged method to raise the event
        //// The calling member's name will be used as the parameter.
        //protected virtual void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
        //#endregion
    }
}

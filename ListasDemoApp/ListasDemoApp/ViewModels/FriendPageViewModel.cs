using ListasDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListasDemoApp.ViewModels
{
    public class FriendPageViewModel
    {
        public Command SaveFriendCommand { get; set; }
        public Command DeleteFriendCommand { get; set; }
        public Friend NewFriend { get; set; }
        private readonly INavigation Navigation;

        public FriendPageViewModel(INavigation navigation)
        {
            NewFriend = new Friend();
            SaveFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }

        public FriendPageViewModel(INavigation navigation, Friend friend)
        {
            NewFriend = friend;
            SaveFriendCommand = new Command(async () => await SaveFriend());
            DeleteFriendCommand = new Command(async () => await DeleteFriend());
            Navigation = navigation;
        }

        private async Task SaveFriend()
        {
            _ = await App.Database.SaveItemAsync(NewFriend);
            await Navigation.PopToRootAsync();
        }
        private async Task DeleteFriend()
        {
            _ = await App.Database.DeleteItemAsync(NewFriend);
            await Navigation.PopToRootAsync();
        }
    }
}

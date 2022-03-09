using ListasDemoApp.Models;
using ListasDemoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListasDemoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendPage : ContentPage
    {
        public FriendPage(Friend friend = null)
        {
            InitializeComponent();

            if (friend == null)
            {
                BindingContext = new FriendPageViewModel(Navigation);
                BtnDelete.IsVisible = false;
            }
            else
            {
                BindingContext = new FriendPageViewModel(Navigation, friend);
                BtnDelete.IsVisible = true;
            }
        }
    }
}
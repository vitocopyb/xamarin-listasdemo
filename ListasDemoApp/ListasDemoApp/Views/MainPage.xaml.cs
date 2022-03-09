using ListasDemoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListasDemoApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // se cambia de lugar, porque aqui siempre obtendra el listado inicial de elementos y despues no se actualizara si se agregan nuevos items
            //BindingContext = new MainPageViewModel();
        }

        // este metodo se ejecuta cada vez que se cargue la vista, por lo que el binding se actualizara con la ultima informacion
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new MainPageViewModel(Navigation);
        }
    }
}

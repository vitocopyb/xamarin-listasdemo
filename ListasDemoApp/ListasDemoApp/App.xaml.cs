using ListasDemoApp.Data;
using ListasDemoApp.Services;
using ListasDemoApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListasDemoApp
{
    public partial class App : Application
    {
        private static FriendDatabase database;

        public static FriendDatabase Database
        {
            get
            {
                if (database == null)
                {
                    string dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db3");
                    database = new FriendDatabase(dbPath);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

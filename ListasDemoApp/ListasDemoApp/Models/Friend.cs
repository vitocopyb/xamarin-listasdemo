using ListasDemoApp.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ListasDemoApp.Models
{
    //public class Friend : INotifyPropertyChanged
    public class Friend : ViewModelBase
    {
        private string firstName;
        private string phone;
        private string email;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged();
            }
        }
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => email; set
            {
                email = value;
                OnPropertyChanged();
            }
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

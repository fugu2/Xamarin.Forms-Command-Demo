using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CommandDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ButtonCommand { get; private set; }

        public ViewModel()
        {
            
            ButtonCommand = new Command(ButtonCommandMethod);
        }

        public void ButtonCommandMethod() 
        {
            App.Current.MainPage.DisplayAlert("Alert", "This is an alert", "Ok");
        } 

    }
}

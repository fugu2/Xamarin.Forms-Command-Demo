using Xamarin.Forms;
using System;

namespace CommandDemo
{
    public partial class CommandDemoPage : ContentPage
    {
        ViewModel viewModel;

        public CommandDemoPage()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}

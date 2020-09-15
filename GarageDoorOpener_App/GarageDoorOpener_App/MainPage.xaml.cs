using GarageDoorOpener_App.Utilities;
using System;
using Xamarin.Forms;

namespace GarageDoorOpener_App
{
    public partial class MainPage : ContentPage
    {
        private GarageDoor _garageDoor;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            _garageDoor = new GarageDoor();
        }

        private async void Open_Clicked(object sender, EventArgs e)
        {
            await _garageDoor.Open();
        }
    }
}

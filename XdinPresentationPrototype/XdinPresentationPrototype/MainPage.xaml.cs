using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XdinPresentationPrototype
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            menu.Source = ImageSource.FromResource("XdinPresentationPrototype.Images.menulogo.PNG");
            logo.Source = ImageSource.FromResource("XdinPresentationPrototype.Images.logoxdin.png");
        }

        private void Menu_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Menu","I AM MENU! RAWR!!!!","Okay, im scared");
        }
    }
}

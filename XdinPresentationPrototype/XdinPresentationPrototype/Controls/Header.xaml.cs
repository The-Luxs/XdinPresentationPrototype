using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XdinPresentationPrototype.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Header : Xamarin.Forms.Grid
    {
        public Header()
        {
            InitializeComponent();

            menu.Source = ImageSource.FromResource("XdinPresentationPrototype.Images.menulogo.PNG");
            logo.Source = ImageSource.FromResource("XdinPresentationPrototype.Images.logoxdin.png");
        }

        private void Menu_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => await Application.Current.MainPage.DisplayAlert("Menu", "I AM MENU! RAWR!!!!", "Okay, im scared"));
            //DisplayAlert("Menu", "I AM MENU! RAWR!!!!", "Okay, im scared");
        }
    }
}
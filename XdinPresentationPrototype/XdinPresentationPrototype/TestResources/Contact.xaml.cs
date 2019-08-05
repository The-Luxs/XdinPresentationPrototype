using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XdinPresentationPrototype.TestResources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Btnclick_Clicked(object sender, EventArgs e)
        {
            var location = new Location(36.075769, -79.968707);
            var options = new MapLaunchOptions
            {
                Name = "Xdin"
            };
            Map.OpenAsync(location, options);

        }
    }
}
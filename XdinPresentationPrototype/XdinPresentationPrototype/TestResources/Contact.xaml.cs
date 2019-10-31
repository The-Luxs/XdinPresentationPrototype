using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Windows.Input;

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

            try
            {
                Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

        }
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });

        void ProcessException(Exception ex)
        {
            if (ex != null)
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }

        private void EmailLindaClick_Clicked(object sender, EventArgs e)
        {
            try
            {
                Email.ComposeAsync(string.Empty, string.Empty, "linda.norberg@xdin.com");
            }
            catch(Exception ex)
            {
                ProcessException(ex);
            }
            
        }

        private void CallLinda_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("+13366889049");
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

        }

        private void CallMattias_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("+13365493351");
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

        }
    }
}
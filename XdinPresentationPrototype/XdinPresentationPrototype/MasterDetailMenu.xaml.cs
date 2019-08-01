using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XdinPresentationPrototype
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMenu : Shell
    {
        public MasterDetailMenu()
        {
            InitializeComponent();

            //header.Source = ImageSource.FromResource("XdinPresentationPrototype.Images.logoxdin.png");
        }
    }
}
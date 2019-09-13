using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XdinPresentationPrototype.Models;

namespace XdinPresentationPrototype.TestResources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

            BindingContext = this;

            var homeSection = new List<HomeTextSection>
            {
                new HomeTextSection{
                header = "ALTEN'S 3 SERVICES",
                text = "ALTEN develops processes to identify skills and expectations so as to ensure that its projects closely match its employees’ desires. /n The ALTEN HR process is based on three types of interview: an annual assessment, follow - up interviews and career interviews.This dynamic, cross departmental and transnational career management ensures the constant evolution, both horizontally and vertically, of the group’s employees working in the managerial and technical fields, opening up new prospects for their professional development.",
                imageUrl= "xdinImage_Career.jpg" } ,
                 new HomeTextSection{
                header = "2018 ANNUAL RESULTS ARE IN",
                text = "SHARP BUSINESS GROWTH IN 2018: +14.4% Revenue reaches €2,269.9 M /n with an increase of 14.4% as compared to 2017. On [...]",
                imageUrl= "xdinImage_AnnualResults.jpg" },
                  new HomeTextSection{
                header = "NEW MOBILE APP UNDER CONSTRUCTION",
                text = "New Xdin mobile app for both IOS and Android are underconstruction an will be finished shortly!",
                imageUrl= "xdinImage_Construction.jpg" }
            };

            homeSectionList.ItemsSource = homeSection;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GmitProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void West_Clicked(object sender, EventArgs e)
        {
            var nui = new Uri("https://www.mezzino.co.uk/locations/galway/the-westwood/?gclid=Cj0KCQiA2vjuBRCqARIsAJL5a-KwQSnk1e4DzQb5i5NMRVr1heHlTtprHsDbBXDTjsAIIA6IJNi5cvAaAvs6EALw_wcB");
            Device.OpenUri(nui);


        }


        private void Gmit_Clicked(object sender, EventArgs e)
        {
            var gmit = new Uri("https://www.gmit.ie/general/accommodation ");
            Device.OpenUri(gmit);

        }

        private void Snoozels_Clicked(object sender, EventArgs e)
        {
            var snoozle = new Uri("https://www.snoozleshostelgalway.ie/ ");
            Device.OpenUri(snoozle);
        }

        private void Nui_Clicked(object sender, EventArgs e)
        {
            var nui = new Uri("https://www.campusaccommodation.ie/");
            Device.OpenUri(nui);
        }
    }
}
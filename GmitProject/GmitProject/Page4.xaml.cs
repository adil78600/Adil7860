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
	public partial class Page4 : ContentPage
	{
        public Page4()
        {
            InitializeComponent();
        }



        private void Aib_Clicked(object sender, EventArgs e)
        {
            var aib = new Uri("https://aib.ie/ ");
            Device.OpenUri(aib);
        }

        private void Boi_Clicked(object sender, EventArgs e)
        {
            var boi = new Uri(" https://www.365online.com/online365/spring/authentication?execution=e1s1");
            Device.OpenUri(boi);
        }

        private void Transferwise_Clicked(object sender, EventArgs e)
        {
            var transferwise = new Uri("https://transferwise.com/ie ");
            Device.OpenUri(transferwise);
        }

        private void Westronunion_Clicked(object sender, EventArgs e)
        {
            var westrenunion = new Uri("https://www.westernunion.com/ie/en/home.html");
            Device.OpenUri(westrenunion);

        }
    }
}
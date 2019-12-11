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
	public partial class Page2 : ContentPage
	{
        public Page2()
        {
            InitializeComponent();
        }
        private void Supermaces_Clicked(object sender, EventArgs e)
        {
            var westwood = new Uri("https://www.supermacs.ie/store/eyre-square/");
            Device.OpenUri(westwood);
        }

        private void Justeat_Clicked(object sender, EventArgs e)
        {
            var justeat = new Uri("https://www.just-eat.ie/?gclid=Cj0KCQiA2vjuBRCqARIsAJL5a-LysiffA1xCPKVnLIiurFAyH3xHpFYRSBDyAIEw19kyONBE9RGNvPMaAnk1EALw_wcB");
            Device.OpenUri(justeat);
        }
        private void Dominos_Clicked(object sender, EventArgs e)
        {
            var dominoes = new Uri("https://www.dominos.ie/?gclid=Cj0KCQiA2vjuBRCqARIsAJL5a-K_CGcAyuFpbwLGEw8fNHedoIKK-9-ttKbDiAJ8vhfeKYMn9dmxggsaAoUrEALw_wcB");
            Device.OpenUri(dominoes);
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var charcoal = new Uri("http://www.charcoalgrilltakeaway.com/");
            Device.OpenUri(charcoal);
        }
    }
}
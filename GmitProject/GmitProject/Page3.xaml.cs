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
	public partial class Page3 : ContentPage
	{
        public Page3()
        {
            InitializeComponent();
        }



        private void Gobus_Clicked(object sender, EventArgs e)
        {
            var gobus = new Uri("https://www.gobus.ie/ ");
            Device.OpenUri(gobus);
        }

        private void Train_Clicked(object sender, EventArgs e)
        {
            var train = new Uri("https://www.irishrail.ie/Offer/webfares?gclid=Cj0KCQiA2vjuBRCqARIsAJL5a-KKZlk5ARuv8Ird-G9eKCQlr6RqpLWDR4JcODifRfk6FN4TiyQyFkcaAv80EALw_wcB&gclsrc=aw.ds ");
            Device.OpenUri(train);
        }

        private void Taxi_Clicked(object sender, EventArgs e)
        {
            var taxi = new Uri("https://elptoo.io/taxi-booking/?c=Galway&gclid=Cj0KCQiA2vjuBRCqARIsAJL5a-K8OvhBKn-pn022Euev0SiPWtVu8jMeAFnZpG2IGeXA2ddCy9SUaNgaAon4EALw_wcB ");
            Device.OpenUri(taxi);
        }

        private void Buses_Clicked(object sender, EventArgs e)
        {
            var localbus = new Uri("http://www.galwaytransport.info/2009/07/city-bus-services.html ");
            Device.OpenUri(localbus);
        }
    }
}
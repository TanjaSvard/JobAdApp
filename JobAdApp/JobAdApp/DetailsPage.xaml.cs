using JobAdApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JobAdApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPage : ContentPage
	{
      private JobAd detailAd;

        public DetailsPage (JobAd ad)
		{
            detailAd = ad;
            BindingContext = detailAd;
            InitializeComponent ();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace JobAdApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //MainPage = new JobAdApp.MainPage();
            MainPage = new NavigationPage(new MainPage());
           
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("android=c3be4dc3-a74f-4523-8c4a-4185f02a5973;" + "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes

		}
	}
}

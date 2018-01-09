using JobAdApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JobAdApp
{
    public partial class MainPage : ContentPage
    {

        RootObject root = new RootObject();
        readonly DataManager manager = new DataManager();
        IList<JobAd> adCollection = new ObservableCollection<JobAd>();

        public MainPage()
        {
            root.ResultFromApi = new ResultFromApi();
            root.ResultFromApi.JobAds = new List<JobAd>();
            ListingAllApiInfo();
            BindingContext = adCollection;
            InitializeComponent();
        }

        async void ListingAllApiInfo()
        {
            root = await manager.GetAll();
            this.IsBusy = true;

            try
            {
                root = await manager.GetAll();
            }
            finally
            {
                this.IsBusy = false;
            }
          

            adCollection.Clear();

            foreach (JobAd ad in root.ResultFromApi.JobAds)
            {
                adCollection.Add(ad);
            }

        }

        async void ListingSearchMatch(Object sender, EventArgs e)
        {
            root = await manager.Search(searchBar.Text);
            this.IsBusy = true;

            try
            {
                root = await manager.Search(searchBar.Text);
            }
            finally
            {
                this.IsBusy = false;
            }
      
            adCollection.Clear();

            if (root.ResultFromApi.JobAds.Count() == 0)
            {
               await DisplayAlert("Inga träffar", "", "OK");
            }

            

            foreach (JobAd ad in root.ResultFromApi.JobAds)
            {             
                    adCollection.Add(ad);
              
            }
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            //navigering till SearchResultPage
            Navigation.PushAsync(new SearchResultPage());
        }

        async void OnViewDetails(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushModalAsync(
                new DetailsPage((JobAd)e.Item));
        }
    }
}

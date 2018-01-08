using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAdApp.Data
{
    public class RootObject
    {
        [JsonProperty(PropertyName = "matchningslista")] 
        public ResultFromApi ResultFromApi { get; set; }
    }

    public class ResultFromApi
    {
        [JsonProperty(PropertyName = "antal_platsannonser")]
        public int NumberOfAds { get; set; }

        [JsonProperty(PropertyName = "antal_platsannonser_exakta")]
        public int NumberOfAdsPerfectMatch { get; set; }

        [JsonProperty(PropertyName = "antal_platsannonser_narliggande")]
        public int NumberOfAdsNearby { get; set; }

        [JsonProperty(PropertyName = "antal_platserTotal")]
        public int NumberOfAllPositions { get; set; }

        [JsonProperty(PropertyName = "antal_sidor")]
        public int NumberOfPages { get; set; }

        [JsonProperty(PropertyName = "matchningdata")]
        public IEnumerable<JobAd> JobAds { get; set; }


    }
}

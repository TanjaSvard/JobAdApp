using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAdApp.Data
{
    public class JobAd
    {
        [JsonProperty(PropertyName = "annonsid")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "annonsrubrik")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "yrkesbenamning")]
        public string PositionDescription { get; set; }

        [JsonProperty(PropertyName = "yrkesbenamningId")]
        public int PositionId { get; set; }

        [JsonProperty(PropertyName = "arbetsplatsnamn")]
        public string CompanyName { get; set; }

        [JsonProperty(PropertyName = "kommunnamn")]
        public string MunicipalityName { get; set; }

        [JsonProperty(PropertyName = "kommunkod")]
        public int MunicipalityId { get; set; }

        [JsonProperty(PropertyName = "publiceraddatum")]
        public string PublishingDate { get; set; }

        [JsonProperty(PropertyName = "sista_ansokningsdag")]
        public string ApplyDate { get; set; }

        [JsonProperty(PropertyName = "annonsurl")]
        public string AdUrl { get; set; }

        [JsonProperty(PropertyName = "relevans")]
        public int Relevance { get; set; }

        [JsonProperty(PropertyName = "antalplatser")]
        public string NumberOfPositions { get; set; }

        [JsonProperty(PropertyName = "antalPlatserVisa")]
        public int NumberOfPositionsToShow { get; set; }

        [JsonProperty(PropertyName = "varaktighetId")]
        public int DurationId { get; set; }

        [JsonProperty(PropertyName = "lanid")]
        public int RegionId { get; set; }


        [JsonProperty(PropertyName = "lan")]
        public string RegionName { get; set; }

        [JsonProperty(PropertyName = "anstallningstyp")]
        public string EmploymentType { get; set; }


    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kipu.KipuApi.Models
{
    public class KipuCanadaInsurance
    {
        [JsonProperty("identifier")]
        public string MemberId { get; set; }
        [JsonProperty("medical_identifier")]
        public string GroupId { get; set; }
        [JsonProperty("province")]
        public string ProvinceAbrev { get; set; }
        [JsonProperty("expiration_date")]
        public string TerminationDate { get; set; }
        [JsonProperty("issue_date")]
        public string EffectiveDate { get; set; }
    }
}

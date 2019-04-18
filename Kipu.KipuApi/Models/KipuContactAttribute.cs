using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kipu.KipuApi.Models
{
    public class KipuContactAttribute
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("contact_type")]
        public string ContactType { get; set; }
        [JsonProperty("relationship")]
        public string Relationship { get; set; }
        [JsonProperty("alternative_phone")]
        public string AlternativePhone { get; set; }
    }
}

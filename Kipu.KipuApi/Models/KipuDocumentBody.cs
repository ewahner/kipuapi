using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kipu.KipuApi.Models
{
    public class KipuDocumentBody
    {
        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }
        [JsonProperty("sending_app_name")]
        public string SendingAppName { get; set; }
        [JsonProperty("data")]
        public KipuPatientData KipuPatientData { get; set; }
    }
}

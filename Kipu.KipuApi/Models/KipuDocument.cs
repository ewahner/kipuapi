using Newtonsoft.Json;

namespace Kipu.KipuApi.Models
{
    public class KipuDocument
    {
        [JsonProperty("document")]
        public KipuDocumentBody KipuDocumentBody { get; set; }
    }
}

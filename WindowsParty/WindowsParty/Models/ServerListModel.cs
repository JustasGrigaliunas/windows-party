using Newtonsoft.Json;

namespace WindowsParty.Models
{
    [JsonObject]
    public class ServerListModel
    {
        [JsonProperty(PropertyName = "name")]
        public string name { set; get; }
        [JsonProperty(PropertyName = "distance")]
        public string distance { set; get; }
    }
}

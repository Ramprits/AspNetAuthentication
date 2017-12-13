using Newtonsoft.Json;

namespace AspNetAuthentication.Helper {
    public abstract class Resource {
        [JsonProperty (Order = -2)]
        public string Href { get; set; }

    }
}
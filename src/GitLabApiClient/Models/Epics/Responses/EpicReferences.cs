using Newtonsoft.Json;

namespace GitLabApiClient.Models.Epics.Responses
{
    public sealed class EpicReferences
    {
        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("relative")]
        public string Relative { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

    }
}

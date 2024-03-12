using Newtonsoft.Json;

namespace GitLabApiClient.Models.Epics.Responses
{
    public sealed class EpicLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("epic_issues")]
        public string EpicIssues { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Epics.Responses
{
    public sealed class Epic : ModifiableObject
    {
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("parent_iid")]
        public int ParentIid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("state")]
        public EpicState State { get; set; }

        [JsonProperty("confidential")]
        public bool Confidential { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl {  get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("references")]
        public EpicReferences References { get; set; }

        [JsonProperty("author")]
        public Assignee Author { get; set; }

        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("start_date_is_fixed")]
        public bool StartDateIsFixed { get; set; }

        [JsonProperty("start_date_fixed")]
        public DateTime? StartDateFixed { get; set; }

        [JsonProperty("start_date_from_milestones")]
        public DateTime? StartDateFromMilestones { get; set; }

        [JsonProperty("start_date_from_inherited_source")]
        public DateTime? StartDateFromInheritedSource { get; set; }

        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; }

        [JsonProperty("due_date_from_milestones")]
        public DateTime? DueDateFromMilestones { get; set; }

        [JsonProperty("due_date_from_inherited_source")]
        public DateTime? DueDateFromInheritedSource { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty("labels")]
        public List<string> Labels { get; } = new List<string>();

        [JsonProperty("upvotes")]
        public int Upvotes { get; set; }

        [JsonProperty("downvotes")]
        public int Downvotes { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("_links")]
        public EpicLinks Links { get; set; }

    }
}

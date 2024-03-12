using System;
using System.Collections.Generic;
using GitLabApiClient.Models.Groups.Requests;
using GitLabApiClient.Models.Issues.Responses;

namespace GitLabApiClient.Models.Epics.Requests
{
    public sealed class EpicQueryOptions
    {
        public int? AuthorId { get; set; }
        public string AuthorUsername {  get; set; }
        public List<string> Labels { get; set; }
        public bool? WithLabelsDetails { get; set; }
        public EpicsOrder OrderBy { get; set; }
        public GroupsSort Sort { get; set; } = GroupsSort.Descending;
        public string Search { get; set; }
        public IssueState? State { get; set; }
        public DateTime? CreatedAfter { get; set; }
        public DateTime? CreatedBefore { get; set; }
        public DateTime? UpdateAfter { get; set; }
        public DateTime? UpdatedBefore { get; set; }
        public bool? IncludeAncestorGroups { get; set; }
        public bool? IncludeDescendantGroups { get; set; }
        public EpicsReactionEmoji? MyReactionEmoji { get; set; }
    }
}

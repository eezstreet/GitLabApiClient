using GitLabApiClient.Models.Epics.Requests;

namespace GitLabApiClient.Internal.Queries
{
    internal class EpicsQueryBuilder : QueryBuilder<EpicQueryOptions>
    {
        protected override void BuildCore(Query query, EpicQueryOptions options)
        {
            if (options.AuthorId.HasValue)
                query.Add("author_id", options.AuthorId.Value);
            if (!string.IsNullOrEmpty(options.AuthorUsername))
                query.Add("author_username", options.AuthorUsername);
            if (options.Labels.Count != 0)
                query.Add("labels", string.Join(",", options.Labels));
            if (options.WithLabelsDetails.HasValue)
                query.Add("with_labels_details", options.WithLabelsDetails.Value);
            if (options.OrderBy != EpicsOrder.CreatedAt)
                query.Add("order_by", options.OrderBy.ToString());
            if (options.Sort != Models.Groups.Requests.GroupsSort.Ascending)
                query.Add("sort", options.Sort.ToString());
            if (!string.IsNullOrEmpty(options.Search))
                query.Add("search", options.Search);
            if (options.State != null)
                query.Add("state", options.State.ToString());
            if (options.CreatedAfter.HasValue)
                query.Add("created_after", options.CreatedAfter.Value);
            if (options.CreatedBefore.HasValue)
                query.Add("created_before", options.CreatedBefore.Value);
            if (options.UpdateAfter.HasValue)
                query.Add("updated_after", options.UpdateAfter.Value);
            if (options.UpdatedBefore.HasValue)
                query.Add("updated_before", options.UpdatedBefore.Value);
            if (options.IncludeAncestorGroups.HasValue)
                query.Add("include_ancestor_groups", options.IncludeAncestorGroups.Value);
            if (options.IncludeDescendantGroups.HasValue)
                query.Add("include_descendant_groups", options.IncludeDescendantGroups.Value);
            if (options.MyReactionEmoji.HasValue)
                query.Add("my_reaction_emojis", options.MyReactionEmoji.ToString());

        }
    }
}

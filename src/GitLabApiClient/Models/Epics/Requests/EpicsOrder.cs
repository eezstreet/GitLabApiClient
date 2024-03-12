using System.Runtime.Serialization;

namespace GitLabApiClient.Models.Epics.Requests
{
    public enum EpicsOrder
    {
        [EnumMember(Value = "created_at")]
        CreatedAt,
        [EnumMember(Value = "updated_at")]
        UpdatedAt,
        [EnumMember(Value = "title")]
        Title,
    }
}

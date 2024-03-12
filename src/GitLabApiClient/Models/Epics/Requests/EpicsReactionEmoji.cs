using System.Runtime.Serialization;

namespace GitLabApiClient.Models.Epics.Requests
{
    public enum EpicsReactionEmoji
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Any")]
        Any,
    }
}

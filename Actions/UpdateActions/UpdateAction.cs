using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.UpdateActions
{
    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    public class UpdateAction : Action
    {
        /// <summary>
        /// Thing  - A sub property of object. The collection target of the action. Supersedes <see cref="Collection"/>.
        /// </summary>
        [JsonProperty("targetCollection")]
        public Thing TargetCollection { get; set; }

        /// <summary>
        /// Thing  - A sub property of object. The collection target of the action. Superseded by <see cref="TargetCollection"/>.
        /// </summary>
        [JsonProperty("collection")]
        public Thing Collection { get; set; }
    }
}

﻿using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.UpdateActions
{
    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    public class InsertAction : AddAction
    {
        /// <summary>
        /// Place - A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [JsonProperty("toLocation")]
        public Place ToLocation { get; set; }
    }
}

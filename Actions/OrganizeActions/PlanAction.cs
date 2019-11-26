﻿using System;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.OrganizeActions
{
    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    public class PlanAction : Action
    {
        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        [JsonProperty("scheduledTime")]
        public DateTime? ScheduledTime
        {
            get;
            set;
        }
    }
}

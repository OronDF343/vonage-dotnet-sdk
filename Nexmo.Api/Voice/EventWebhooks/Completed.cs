﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nexmo.Api.Voice.EventWebhooks
{
    public class Completed : CallStatusEvent
    {
        /// <summary>
        /// Timestamp (ISO 8601 format) of the end time of the call
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The type of network that was used in the call
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// Call length (in seconds)
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601 format)
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Cost per minute of the call (EUR)
        /// </summary>
        [JsonProperty("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Total cost of the call (EUR)
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
    }
}

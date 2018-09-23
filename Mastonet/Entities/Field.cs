using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mastonet.Entities
{
    public class Field
    {
        /// <summary>
        /// Field name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Field value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

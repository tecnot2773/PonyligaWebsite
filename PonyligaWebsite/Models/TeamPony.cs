using System.Text.Json;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

using System;
using System.Collections.Generic;
using System.Text;

namespace PonyligaWebsite.Models
{
    public class TeamPony
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int teamId { get; set; }
        public Team team { get; set; }
        public int ponyId { get; set; }
        public Pony pony { get; set; }

    }
}

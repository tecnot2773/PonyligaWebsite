using System.Text.Json;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

using System;
using System.Collections.Generic;
using System.Text;

namespace PonyligaWebsite.Models
{
    public class Team
    {

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int id { get; set; }
        public string club { get; set; }
        public string name { get; set; }
        public int place { get; set; }
        public string consultor { get; set; }
        public int teamSize { get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? groupId { get; set; }
        public Group group { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int totalScore { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string game { get; set; }

        public ICollection<Pony> ponies { get; set; }
        public ICollection<TeamMember> teamMembers { get; set; }
        public ICollection<Result> results { get; set; }
        public ICollection<TeamPony> teamPonies { get; set; }

        public override string ToString()
        {
            return $"Place: {place}, Game: {game}";
        }

    }
}

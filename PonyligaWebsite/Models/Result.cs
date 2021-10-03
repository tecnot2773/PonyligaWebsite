
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;



namespace PonyligaWebsite.Models
{
    public class Result
    {
        public int id { get; set; }
        public String gameDate { get; set; }
        public String game { get; set; }
        public int position { get; set; }
        public String time { get; set; }
        public int score { get; set; }
        public int teamId { get; set; }
        public Team team { get; set; }
        public String penaltyTime { get; set; }
       
    }
}

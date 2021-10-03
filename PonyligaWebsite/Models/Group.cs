using System.Text.Json;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

using System;
using System.Collections.Generic;
using System.Text;

namespace PonyligaWebsite.Models
{
    public class Group
    {

        public int id { get; set; }
        public String name { get; set; }
        public int rule { get; set; }

        public ICollection<Team> teams { get; set; }
        public int groupSize { get; set; }
        public String participants { get; set; }

    }
}

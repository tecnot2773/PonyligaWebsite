using System.Text.Json;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PonyligaWebsite.Models
{
    public class TeamMember
    {
        public int id { get; set; }
        public String firstName { get; set; }
        public String surName { get; set; }
        public int teamId { get; set; }
        public Team team { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace PonyligaWebsite.Models
{
    public class User
    {
        public int id { get; set; }
        public String firstName { get; set; }
        public String surName { get; set; }
        public String loginName { get; set; }
        public String passwordHash { get; set; }
        public int userPrivileges { get; set; }



    }
}

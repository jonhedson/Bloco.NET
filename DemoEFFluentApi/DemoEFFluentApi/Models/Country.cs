using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace DemoEFFluentApi.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public DateTime AddedOne { get; set; }

        public ICollection<City> City { get; set; }
    }
}

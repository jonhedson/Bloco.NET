using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFFluentApi.Models
{
    public class CityInformation
    {
        public int Id { get; set; }
        public int Population { get; set; }
        public int OtherName { get; set; }
        public int MayorName { get; set; }

        public City City { get; set;  }
    }
}

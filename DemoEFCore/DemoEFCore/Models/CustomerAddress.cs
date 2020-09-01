using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEFCore.Models
{
    public class CustomerAddress
    {

        public int id { get; set; }
        public int CustomerID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Customer Customer { get; set; }
    }
}

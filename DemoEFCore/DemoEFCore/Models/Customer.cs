using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoEFCore.Models
{
    [Table("CustomerMaster")]
    public class Customer
    {
        public Customer()
        {
            Contact = new ContactInfo();
        }
        
        public int CustomerId { get; set; }
        
        
        public int Customerno { get; set; }
        public string CustomerName { get; set; }
        public string Phoneno { get; set; }
        public ContactInfo Contact { get; set; }


        public CustomerAddress CustomerAddress { get; set; }
    }
}

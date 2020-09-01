using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyCooking.BLL.Models
{
    public class User : BaseEntity
    {
        
        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerable<Recipe> Recipes { get; set; }
    }
}

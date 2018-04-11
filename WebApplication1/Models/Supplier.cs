using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Supplier
    {
        public int SupplierId{ get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public int Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Website { get; set; }
        public string Country { get; set; }
    }
}
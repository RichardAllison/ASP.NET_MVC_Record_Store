using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime Time { get; set; }
        public float Price { get; set; }
        public bool CompletedStatus { get; set; }
    }
}
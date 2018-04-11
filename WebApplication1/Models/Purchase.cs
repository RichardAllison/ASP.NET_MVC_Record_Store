using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public DateTime OrderTime { get; set; }
        public float Cost { get; set; }
        public bool OrderStatus { get; set; }
        public bool DeliveryStatus { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}
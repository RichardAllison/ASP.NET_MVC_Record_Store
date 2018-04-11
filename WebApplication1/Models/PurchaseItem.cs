using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PurchaseItem
    {
        public int PurchaseItemId { get; set; }
        public int PurchaseId { get; set; }
        public int StockItemId { get; set; }
        public int Quantity { get; set; }
        public int UnitCost { get; set; }
    }
}
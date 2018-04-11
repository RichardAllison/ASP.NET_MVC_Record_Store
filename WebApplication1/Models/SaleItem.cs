using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SaleItem
    {
        public int SaleItemId { get; set; }
        public int SaleId { get; set; }
        public int StockItemId { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
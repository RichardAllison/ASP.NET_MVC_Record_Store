using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Stock
    {
        public int StockItemId { get; set; }
        public int AlbumId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Quantity { get; set; }
        public int QuantityReserved { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityAvailable { get; set; }
        public int LowStockLevel { get; set; }
        public int HighStockLevel { get; set; }
        public float SalePrice { get; set; }
        public float UnitCost { get; set; }
    }
}
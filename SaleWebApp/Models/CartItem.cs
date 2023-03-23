﻿namespace SaleWebApp.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; } = null!;
        public string Weight { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}

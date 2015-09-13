using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace srisai_international.Models
{
    public class Orders
    {
        public Guid OrderId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string ShippingAddress { get; set; }

        public string PaymentMode { get; set; }
        public bool IsPaid { get; set; }
    }


    public class OrderDetails
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
    }


    public class Product
    {
        public int Id { get; set; }
        public string PorductName { get; set; }
        public string ProductDescription { get; set; }

        public bool IsAvailable { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace RyansOrderApp.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Item { get; set; }
    }
}

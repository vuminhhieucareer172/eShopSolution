using eShopSolution.Data.Enums;
using System;

namespace eShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public int ShipName { get; set; }
        public int ShipAddress { get; set; }
        public int ShipEmail { get; set; }
        public int ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flattening
{
    class Program
    {
        static void Main(string[] args)
        {
            // Complex model
            var customer = new Customer
            {
                Name = "George Costanza"
            };

            var order = new Order
            {
                Customer = customer
            };

            var bosco = new Product
            {
                Name = "Bosco",
                Price = 4.99m
            };

            order.AddOrderLineItem(bosco, 15);

            // Configure AutoMapper
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDto>());

            // Perform mapping
            OrderDto dto = Mapper.Map<Order, OrderDto>(order);

            // per convenzione CustomerName viene mappato con Customer.Name
            // e Total con GetTotal()
            //dto.CustomerName.ShouldEqual("George Costanza");
            //dto.Total.ShouldEqual(74.85m);
        }
    }
}

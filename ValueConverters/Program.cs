using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueConverters
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

            Mapper.Initialize(cfg => {
                cfg.CreateMap<Order, OrderDto>()
                    .ForMember(d => d.Amount, opt => opt.ConvertUsing(new CurrencyFormatter(), src => src.GetTotal()));
                cfg.CreateMap<OrderLineItem, OrderLineItemDto>()
                    .ForMember(d => d.Total, opt => opt.ConvertUsing(new CurrencyFormatter(), src => src.GetTotal()));
            });

            var orderDto = Mapper.Map<OrderDto>(order);

        }
    }
}

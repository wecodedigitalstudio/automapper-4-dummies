using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unflattening
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "Bob"
            };

            var order = new Order
            {
                Customer = customer,
                Total = 15.8m
            };

            Mapper.Initialize(cfg => {
                cfg.CreateMap<Order, OrderDto>()
                   .ReverseMap();       // ==> ReverseMap
            });

            // oppure (ma è inutile)
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Order, OrderDto>()
            //      .ForMember(d => d.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
            //      .ReverseMap()
            //      .ForPath(s => s.Customer.Name, opt => opt.MapFrom(src => src.CustomerName));
            //});

            var orderDto = Mapper.Map<Order, OrderDto>(order);

            orderDto.CustomerName = "Joe";

            order = Mapper.Map<Order>(orderDto);

            // Per convenzione Customer.Name è mappato con CustomerName
            //order.Customer.Name.ShouldEqual("Joe");



        }
    }
}

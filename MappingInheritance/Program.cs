using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingInheritance
{

    public class Order { }
    public class OnlineOrder : Order { }
    public class MailOrder : Order { }

    public class OrderDto { }
    public class OnlineOrderDto : OrderDto { }
    public class MailOrderDto : OrderDto { }

    class Program
    {
        static void Main(string[] args)
        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Order, OrderDto>()
                    .Include<OnlineOrder, OnlineOrderDto>()
                    .Include<MailOrder, MailOrderDto>();
                cfg.CreateMap<OnlineOrder, OnlineOrderDto>();
                cfg.CreateMap<MailOrder, MailOrderDto>();
            });

            // Perform Mapping
            var order = new OnlineOrder();
            var mapped = Mapper.Map(order, order.GetType(), typeof(OrderDto));
            //Assert.IsType<OnlineOrderDto>(mapped);
        }
    }
}

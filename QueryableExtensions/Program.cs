using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryableExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(cfg =>
                cfg.CreateMap<OrderLine, OrderLineDTO>()
                .ForMember(dto => dto.Item, conf => conf.MapFrom(ol => ol.Item.Name)));


        }

        //public static List<OrderLineDTO> GetLinesForOrder(int orderId)
        //{
        //    using (var context = new orderEntities())
        //    {
        //        return context.OrderLines.Where(ol => ol.OrderId == orderId)
        //                 .ProjectTo<OrderLineDTO>().ToList();
        //    }
        //}
    }
}

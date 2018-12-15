using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTranslation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OrderLine, OrderLineDTO>()
                  .ForMember(dto => dto.Item, conf => conf.MapFrom(ol => ol.Item.Name));
                cfg.CreateMap<OrderLineDTO, OrderLine>()
                  .ForMember(ol => ol.Item, conf => conf.MapFrom(dto => dto));
                cfg.CreateMap<OrderLineDTO, Item>()
                  .ForMember(i => i.Name, conf => conf.MapFrom(dto => dto.Item));
            });

            Expression<Func<OrderLineDTO, bool>> dtoExpression = dto => dto.Item.StartsWith("A");
            var expression = Mapper.Map<Expression<Func<OrderLine, bool>>>(dtoExpression);

        }
    }
}

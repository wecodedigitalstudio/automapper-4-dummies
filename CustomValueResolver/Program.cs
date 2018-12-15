using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValueResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(cfg =>
               cfg.CreateMap<Source, Destination>()
                 .ForMember(dest => dest.Total, opt => opt.MapFrom<CustomResolver>()));

            Mapper.AssertConfigurationIsValid();

            var source = new Source
            {
                Value1 = 5,
                Value2 = 7
            };

            var result = Mapper.Map<Source, Destination>(source);

        }
    }
}

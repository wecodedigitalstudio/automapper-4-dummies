using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedMappings
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OuterSource, OuterDest>();
                cfg.CreateMap<InnerSource, InnerDest>();
            });
            config.AssertConfigurationIsValid();

            var source = new OuterSource
            {
                Value = 5,
                Inner = new InnerSource { OtherValue = 15 }
            };
            var mapper = config.CreateMapper();
            var dest = mapper.Map<OuterSource, OuterDest>(source);

            //dest.Value.ShouldEqual(5);
            //dest.Inner.ShouldNotBeNull();
            //dest.Inner.OtherValue.ShouldEqual(15);
        }
    }
}

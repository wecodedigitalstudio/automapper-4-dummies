using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Source, Dest>()
                .ForMember(destination => destination.Value, opt => opt.NullSubstitute("Other Value")));

            var source = new Source { Value = null };
            var mapper = config.CreateMapper();
            var dest = mapper.Map<Source, Dest>(source);

            //dest.Value.ShouldEqual("Other Value");

            source.Value = "Not null";

            dest = mapper.Map<Source, Dest>(source);

            //dest.Value.ShouldEqual("Not null");
        }
    }
}

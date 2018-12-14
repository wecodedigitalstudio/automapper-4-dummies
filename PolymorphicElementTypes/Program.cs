using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicElementTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(c => {
                c.CreateMap<ParentSource, ParentDestination>()
                     .Include<ChildSource, ChildDestination>();
                c.CreateMap<ChildSource, ChildDestination>();
            });

            var sources = new[]
                {
                    new ParentSource(),
                    new ChildSource(),
                    new ParentSource()
                };

            var destinations = Mapper.Map<ParentSource[], ParentDestination[]>(sources);

            //destinations[0].ShouldBeInstanceOf<ParentDestination>();
            //destinations[1].ShouldBeInstanceOf<ChildDestination>();
            //destinations[2].ShouldBeInstanceOf<ParentDestination>();
        }
    }
}

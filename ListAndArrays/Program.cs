using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Source, Destination>());

            var sources = new[]
                {
                    new Source { Value = 5 },
                    new Source { Value = 6 },
                    new Source { Value = 7 }
                };

            IEnumerable<Destination> ienumerableDest = Mapper.Map<Source[], IEnumerable<Destination>>(sources);
            ICollection<Destination> icollectionDest = Mapper.Map<Source[], ICollection<Destination>>(sources);
            IList<Destination> ilistDest = Mapper.Map<Source[], IList<Destination>>(sources);
            List<Destination> listDest = Mapper.Map<Source[], List<Destination>>(sources);
            Destination[] arrayDest = Mapper.Map<Source[], Destination[]>(sources);
        }
    }
}

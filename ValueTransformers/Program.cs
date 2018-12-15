using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTransformers
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(cfg => {
                cfg.ValueTransformers.Add<string>(val => val + "!!!");
            });

            var source = new Source { Value = "Hello" };
            var dest = Mapper.Map<Dest>(source);

            //dest.Value.ShouldBe("Hello!!!");
        }
    }
}

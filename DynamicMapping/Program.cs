using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMapping
{

    public class Foo
    {
        public int Bar { get; set; }
        public int Baz { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dynamic foo = new { Bar = 5, Baz = 6 };

            Mapper.Initialize(cfg => { });

            var result = Mapper.Map<Foo>(foo);
            //result.Bar.ShouldEqual(5);
            //result.Baz.ShouldEqual(6);


        }
    }
}

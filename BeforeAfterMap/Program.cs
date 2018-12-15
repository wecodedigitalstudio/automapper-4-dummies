using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeAfterMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Source, Dest>()
                  .BeforeMap((src, dest) => src.Value = src.Value + 10)
                  .AfterMap((src, dest) => dest.Name = "John");
            });

            //int i = 10;
            //Mapper.Map<Source, Dest>(src, opt => {
            //    opt.BeforeMap((src, dest) => src.Value = src.Value + i);
            //    opt.AfterMap((src, dest) => dest.Name = HttpContext.Current.Identity.Name);
            //});

        }
    }
}

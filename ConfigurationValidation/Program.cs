using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mapper.Initialize(cfg =>
            //    cfg.CreateMap<Source, Destination>());

            //try
            //{
            //    Mapper.Configuration.AssertConfigurationIsValid();
            //}            
            //catch(AutoMapperConfigurationException)
            //{
            //    Console.WriteLine("Invalid configuration");
            //}

            Mapper.Initialize(cfg =>
              cfg.CreateMap<Source, Destination>()
                .ForMember(dest => dest.SomeValuefff, opt => opt.Ignore())
            );

            Mapper.Configuration.AssertConfigurationIsValid();

        }
    }
}

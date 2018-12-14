using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypeConverters
{
    class Program
    {
        //void ConvertUsing(Func<TSource, TDestination> mappingFunction);
        //void ConvertUsing(ITypeConverter<TSource, TDestination> converter);
        //void ConvertUsing<TTypeConverter>() where TTypeConverter : ITypeConverter<TSource, TDestination>;

        static void Main(string[] args)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<string, int>().ConvertUsing(s => Convert.ToInt32(s));
                cfg.CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConverter());
                cfg.CreateMap<string, Type>().ConvertUsing<TypeTypeConverter>();
                cfg.CreateMap<Source, Destination>();
            });
            Mapper.AssertConfigurationIsValid();

            var source = new Source
            {
                Value1 = "5",
                Value2 = "01/01/2000",
                Value3 = "AutoMapperSamples.GlobalTypeConverters.GlobalTypeConverters+Destination"
            };

            Destination result = Mapper.Map<Source, Destination>(source);
            //result.Value3.ShouldEqual(typeof(Destination));
        }

        public class DateTimeTypeConverter : ITypeConverter<string, DateTime>
        {
            public DateTime Convert(string source, DateTime destination, ResolutionContext context)
            {
                return System.Convert.ToDateTime(source);
            }
        }

        public class TypeTypeConverter : ITypeConverter<string, Type>
        {
            public Type Convert(string source, Type destination, ResolutionContext context)
            {
                return Assembly.GetExecutingAssembly().GetType(source);
            }
        }

    }
}

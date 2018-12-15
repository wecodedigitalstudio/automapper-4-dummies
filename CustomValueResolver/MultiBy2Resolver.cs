using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValueResolver
{
    public class MultBy2Resolver : IValueResolver<object, object, int>
    {
        public int Resolve(object source, object dest, int destMember, ResolutionContext context)
        {
            return destMember * 2;
        }
    }
}

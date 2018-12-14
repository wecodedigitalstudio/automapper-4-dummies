using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unflattening
{
    public class Order
    {
        public decimal Total { get; set; }
        public Customer Customer { get; set; }
    }

}

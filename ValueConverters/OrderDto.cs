using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueConverters
{
    public class OrderDto
    {
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
        public string Amount { get; set; }

        public List<OrderLineItemDto> OrderLineItems { get; set; }

    }
}

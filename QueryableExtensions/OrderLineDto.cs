using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryableExtensions
{
    public class OrderLineDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Item { get; set; }
        public decimal Quantity { get; set; }
    }
}

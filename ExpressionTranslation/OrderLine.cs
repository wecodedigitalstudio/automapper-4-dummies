using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTranslation
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Item Item { get; set; }
        public decimal Quantity { get; set; }
    }
}

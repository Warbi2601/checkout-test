using AudenTT.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenTT
{
    public class Basket
    {
        public List<Item> basketItems { get; set; }
        
        public decimal totalValue { get; set; }
    }
}

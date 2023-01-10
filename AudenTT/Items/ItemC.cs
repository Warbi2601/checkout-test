using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenTT.Items
{
    public class ItemC : Item
    {
        public ItemC()
        {
            ID = "C";
            discountThreshold = 0;
            discountGroupPrice = 0.0M;
            standardPrice = 10.0M;
        }
    }
}

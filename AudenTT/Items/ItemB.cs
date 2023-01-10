using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenTT.Items
{
    public class ItemB : Item
    {
        public ItemB()
        {
            ID = "B";
            discountThreshold = 2;
            discountGroupPrice = 45.0M;
            standardPrice = 30.0M;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenTT.Items
{
    public class ItemA : Item
    {
        public ItemA()
        {
            ID = "A";
            discountThreshold = 3;
            discountGroupPrice = 130.0M;
            standardPrice = 50.0M;
        }
    }
}

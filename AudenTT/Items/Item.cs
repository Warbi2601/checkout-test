using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenTT.Items
{
    public class Item
    {
        public string ID { get; set; }

        public int selectedQty { get; set; }

        public decimal standardPrice { get; set; }

        public int discountThreshold { get; set; }

        public decimal discountGroupPrice { get; set; }

        public decimal summedValue { get; set; }
    }
}

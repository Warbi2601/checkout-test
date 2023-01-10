using AudenTT;
using AudenTT.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenTTTests
{
    public static class BasketData
    {
        public static Basket basketItemSumTestData = new Basket
        {
            basketItems = new List<Item>
                {
                    new ItemA
                    {
                        selectedQty = 1,
                    },
                    new ItemA
                    {
                        selectedQty = 2,
                    },
                    new ItemA
                    {
                        selectedQty = 3,
                    },
                    new ItemA
                    {
                        selectedQty = 4,
                    },
                    new ItemA
                    {
                        selectedQty = 5,
                    },
                    new ItemA
                    {
                        selectedQty = 17,
                    },
                    new ItemB
                    {
                        selectedQty = 1,
                    },
                    new ItemB
                    {
                        selectedQty = 2,
                    },
                    new ItemB
                    {
                        selectedQty = 3,
                    },
                    new ItemC
                    {
                        selectedQty = 1,
                    },
                    new ItemC
                    {
                        selectedQty = 2,
                    },
                    new ItemC
                    {
                        selectedQty = 3,
                    },
                }
        };

        public static Basket basketTotalSumTestData_One_A_One_B_One_C = new Basket
        {
            basketItems = new List<Item>
            {
                new ItemA
                {
                    selectedQty = 3,
                },
                new ItemB
                {
                    selectedQty = 1,
                }
            }
        };

        public static Basket basketTotalSumTestData_Three_A_One_B = new Basket
        {
            basketItems = new List<Item>
            {
                new ItemA
                {
                    selectedQty = 3,
                },
                new ItemB
                {
                    selectedQty = 1,
                }
            }
        };
    }
}

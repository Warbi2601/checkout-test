using AudenTT;
using AudenTT.Items;
using System.Xml;
using Xunit;

namespace AudenTTTests
{
    public class CheckoutTests
    {
        [Fact]
        public void Eight_A_Costs_360() //On reflection this may have been a better way to implement the testing strategy for calculating the individual items
        {
            decimal summedLineValue = Checkout.CalculateDiscount(new ItemA
            {
                selectedQty = 8
            });

            Assert.Equal(360, summedLineValue);
        }

        [Fact]
        public void One_A_Costs_50()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "A", 1, 50.0M);
        }

        [Fact]
        public void Two_A_Costs_100()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "A", 2, 100.0M);
        }

        [Fact]
        public void Three_A_Costs_130()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "A", 3, 130.0M);
        }

        [Fact]
        public void Four_A_Costs_180()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "A", 4, 180.0M);
        }

        [Fact]
        public void Five_A_Costs_230()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "A", 5, 230.0M);
        }

        [Fact]
        public void Seventeen_A_Costs_750()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "A", 17, 750.0M);
        }

        [Fact]
        public void One_B_Costs_30()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "B", 1, 30.0M);
        }

        [Fact]
        public void Two_B_Costs_45()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "B", 2, 45.0M);
        }

        [Fact]
        public void Three_B_Costs_75()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "B", 3, 75.0M);
        }

        [Fact]
        public void One_C_Costs_10()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "C", 1, 10.0M);
        }

        [Fact]
        public void Two_C_Costs_20()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "C", 2, 20.0M);
        }

        [Fact]
        public void Three_C_Costs_30()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "C", 3, 30.0M);
        }

        [Fact]
        public void One_A_One_B_Costs_80()
        {
            Basket b = BasketData.basketItemSumTestData;

            Checkout.CheckoutBasket(ref b);

            TestHelper(b, "A", 1, 50.0M);
            TestHelper(b, "B", 1, 30.0M);
        }

        [Fact]
        public void One_A_One_B_One_C_Costs_90()
        {
            Basket b = new Basket
            {
                basketItems = new List<Item>
                {
                    new ItemA
                    {
                        selectedQty = 1,
                    },
                    new ItemB
                    {
                        selectedQty = 1,
                    },
                    new ItemC
                    {
                        selectedQty = 1,
                    }
                }
            };

            Checkout.CheckoutBasket(ref b);

            Assert.Equal(90, b.totalValue);
        }

        [Fact]
        public void Three_A_One_B_Costs_160()
        {
            Basket b = new Basket
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

            Checkout.CheckoutBasket(ref b);

            Assert.Equal(160, b.totalValue);
        }

        [Fact]
        public void Fifteen_A_TwentyOne_B_Twelve_C_Costs_1250()
        {
            Basket b = new Basket
            {
                basketItems = new List<Item>
                {
                    new ItemA
                    {
                        selectedQty = 15,
                    },
                    new ItemB
                    {
                        selectedQty = 21,
                    },
                    new ItemC
                    {
                        selectedQty = 12,
                    }
                }
            };

            Checkout.CheckoutBasket(ref b);

            Assert.Equal(1250, b.totalValue);
        }

        public void TestHelper(Basket b, string ID, int qty, decimal expectedValue)
        {
            List<Item> validBasketItems = b.basketItems.Where(x => x.ID == ID && x.selectedQty == qty).ToList();

            if (validBasketItems == null || validBasketItems.Count == 0) //then something has gone wrong with the setup and there is no records in the list that match the test case
            {
                Assert.True(false, "The expected item matching the ID and quantity for this test case was not found in the data list"); //Fail on purpose and inform the tester why
                return;
            }

            foreach (var item in validBasketItems)
            {
                Assert.Equal(expectedValue, item.summedValue); //could consider returning the summed value here if we wanted to use this value to sum up multiple test cases
            }
        }
    }
}
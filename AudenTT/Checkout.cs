using AudenTT.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudenTT
{
    public class Checkout
    {
        public static void CheckoutBasket(ref Basket basket)
        {
            //Loop through the lines and calculate the line value including potential discount
            foreach (var item in basket.basketItems)
            {
                item.summedValue = CalculateDiscount(item);
            }

            basket.totalValue = basket.basketItems.Sum(x => x.summedValue);
        }

        public static decimal CalculateDiscount(Item item)
        {
            //if the selected quantity is less than the threshold, then its a simple calc
            if(item.discountThreshold == 0 || item.selectedQty < item.discountThreshold)
            {
                return item.selectedQty * item.standardPrice;
            }

            //otherwise, we have a discount in play

            int noOfDiscountGroups = item.selectedQty / item.discountThreshold; //how many times have we hit the threshold
            int remainder = item.selectedQty % item.discountThreshold; //What is the remainder post threshold
            
            decimal summedGroupValue = noOfDiscountGroups * item.discountGroupPrice; //sum the value of all the discount groups
            decimal summedRemainderValue = remainder * item.standardPrice; //sum the value of the remainder items at the standard price
            decimal summedValue = summedGroupValue + summedRemainderValue; //Calculate final total

            return summedValue;
        }
    }
}

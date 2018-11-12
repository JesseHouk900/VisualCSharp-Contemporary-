/*
 * Class for the cart that will hold the pizzas being ordered
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingApp
{
    public class Cart
    {
        private List<Pizza> pizzas;

        public List<Pizza> PizzaList
        {
            get
            {
                return pizzas;
            }
            set
            {
                if (!(value is null))
                {
                    pizzas = value;
                }
            }
        }
        // return the sum of the prices of the pizzas in the cart
        public decimal GetTotal()
        {
            decimal total = 0m;
            for (int i = 0; i < PizzaList.Count; i++)
            {
                total += PizzaList[i].Price;
            }
            return total;
        }
    }
}

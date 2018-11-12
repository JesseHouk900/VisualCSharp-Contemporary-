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

        public decimal GetTotal()
        {
            decimal total = 0m;
            for (int i = 0; i < PizzaList.Count; i++)
            {
                total += PizzaList[i].Price;
                if (PizzaList[i].Name == "Custom")
                {
                    total += PizzaList[i].BasePrice;
                }
            }
            return total;
        }
    }
}

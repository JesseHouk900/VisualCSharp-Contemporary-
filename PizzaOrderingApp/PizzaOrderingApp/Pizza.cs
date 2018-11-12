using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzaOrderingApp
{
    public class Pizza
    {
        private string name;
        private string [] coreComponent;
        private decimal price;
        private decimal basePrice;
        public List<string> LeftToppings;
        public List<string> RightToppings;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != "")
                {
                    name = value;
                }
            }
        }

        public string Crust
        {
            get
            {
                if (coreComponent != null && coreComponent[0] != null)
                {
                    return coreComponent[0];
                }
                else return "";
            }
            set
            {
                if (coreComponent != null && coreComponent[0] != null)
                {
                    coreComponent[0] = value;
                }

            }
        }
        public string Sauce
        {
            get
            {
                if (coreComponent != null && coreComponent[1] != null)
                {
                    return coreComponent[1];
                }
                else return "";
            }
            set
            {
                if (coreComponent != null && coreComponent[1] != null)
                {
                    coreComponent[1] = value;
                }
            }
        }
        // total price for the pizza
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        // Price based on the size of the pizza
        public decimal BasePrice
        {
            get
            {
                return basePrice;
            }
            set
            {
                basePrice = value;
            }
        }
        // used for custom pizzas
        public Pizza()
        {
            name = "Custom";
            // adds default toppings to pizza, medium crust, tomato sauce, cheese
            DefaultToppings();
        }

        // used for speciality pizzas
        public Pizza(string PizzaName)
        {
            name = PizzaName;
            // adds default toppings to pizza, medium crust, tomato sauce, cheese
            DefaultToppings();
        }

        // copy constructor
        public Pizza(Pizza p2)
        {
            price = p2.Price;
            basePrice = p2.BasePrice;
            coreComponent = new string [2];
            for (int i = 0; i < 2; i++)
            {
                coreComponent[i] = p2.coreComponent[i];
            }
            LeftToppings = new List<string>(p2.LeftToppings.Count);
            for (int i = 0; i < p2.LeftToppings.Count; i++)
            {
                LeftToppings.Add(p2.LeftToppings[i]);
            }
            RightToppings = new List<string>(p2.RightToppings.Count);
            for (int i = 0; i < p2.RightToppings.Count; i++)
            {
                RightToppings.Add(p2.RightToppings[i]);
            }
        }
        // used for first making pizzas
        public void DefaultToppings()
        {
            // initialize an array list that will hold the toppings, with the 0th element as the size of the pizza
            coreComponent = new string [2];
            // make the pizza size a medium
            coreComponent[0] = "medium";
            basePrice = 8m;
            // add tomato sauce to the pizza
            coreComponent[1] = "tomato sauce";
            // add cheese to the pizza
            LeftToppings = new List<string>();
            LeftToppings.Add("cheese");
            RightToppings = new List<string>();
            RightToppings.Add("cheese");
        }

        public decimal GetTotalPrice()
        {
            int lSize = LeftToppings.Count;
            int rSize = RightToppings.Count;
            decimal price = BasePrice;
            for (int i = 0; i < lSize; i++)
            {
                price += CustomizePizzaForm.Toppings[LeftToppings[i]];
            }
            for (int i = 0; i < rSize; i++)
            {
                price += CustomizePizzaForm.Toppings[RightToppings[i]];
            }
            return price;
        }
    }
}

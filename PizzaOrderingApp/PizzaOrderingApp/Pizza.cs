using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PizzaOrderingApp
{
    public class Pizza
    {
        private string name;
        public ArrayList toppings;
        private decimal price;
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

        //public ArrayList Toppings
        //{
        //    get
        //    {
        //        return toppings;
        //    }
        //    set
        //    {
        //        if (!(value is null) && value.Count != 0 && value[0].ToString() != "")
        //        {
        //            toppings = value;
        //        }
        //    }
        //}

        public string Crust
        {
            get
            {
                if (toppings != null && toppings[0] != null)
                {
                    return (string)toppings[0];
                }
                else return "";
            }
            set
            {
                if (toppings != null && toppings[0] != null)
                {
                    toppings[0] = value;
                }
            }
        }
        public string Sauce
        {
            get
            {
                if (toppings != null && toppings[1] != null)
                {
                    return (string)toppings[1];
                }
                else return "";
            }
            set
            {
                if (toppings != null && toppings[1] != null)
                {
                    toppings[1] = value;
                }
            }
        }
        public string Cheese
        {
            get
            {
                if (toppings != null && toppings[2] != null)
                {
                    return (string)toppings[2];
                }
                else return "";
            }
            set
            {
                if (toppings != null && toppings[2] != null)
                {
                    toppings[2] = value;
                }
            }
        }
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
            if (toppings != null)
            {
                toppings.Clear();
            }
            toppings = new ArrayList(p2.toppings.Count);
            for (int i = 0; i < p2.toppings.Count; i++)
            {
                toppings.Add(p2.toppings[i]);
                //toppings[i] = new object();
                //toppings[i] = p2.toppings[i];
            }
        }

        // used for first making pizzas
        public void DefaultToppings()
        {
            // initialize an array list that will hold the toppings, with the 0th element as the size of the pizza
            toppings = new ArrayList();

            // make the pizza size a medium
            toppings.Add("medium");
            // add tomato sauce to the pizza
            toppings.Add("tomato sauce");
            // add cheese to the pizza
            toppings.Add("cheese");
        }

    }
}

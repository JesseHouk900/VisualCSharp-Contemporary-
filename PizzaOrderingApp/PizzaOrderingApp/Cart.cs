using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingApp
{
    public class Cart
    {
        private ArrayList pizzas;

        public ArrayList PizzaList
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
    }
}

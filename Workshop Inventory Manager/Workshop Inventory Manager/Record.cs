/*      Jesse Houk - Record.cs
 *      Purpose - Object that will be an item in the supply list
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Inventory_Manager
{
    // allow a record to be printed to and read from a file using a binary formatter
    [Serializable]
    public class Record
    {
        private string name;
        // public accessor for the name of a record
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private decimal price;
        // public accessor for the price of a record
        public decimal Price
        {
            get { return price; }
            set
            {
                // return a price of 0 if the user tries to make the 
                // price negative
                price = (value > 0m) ? value : 0m;
            }
        }
        private int quantity;
        // public accessor for the quantity of a record
        public int Quantity
        {
            get { return quantity; }
            set
            {
                // return a quantity of 0 if the user tries to make the 
                // quantity negative
                quantity = (value > 0) ? value : 0;
            }
        }
        // default constructor
        public Record()
        {
            name = "";
            price = 0m;
            quantity = 0;
        }
        // copy constructor
        public Record(Record r)
        {
            name = r.Name;
            price = r.Price;
            quantity = r.Quantity;
        }
        // default overridden ToString method that prints the record as a string
        public override string ToString()
        {
            return "   " + name + "\t\t\t$" + price + "\t\t\t" + quantity;
        }
        // method that takes in how far apart the elements of a record should
        // be spaced
        public string ToString(int setW)
        {
            // list of spaces
            List<string> setWs = new List<string>();
            // size of how many spaces to make between the name and price
            int size = setW - name.Length - 1;
            // add an empty string to the list of spaces
            setWs.Add("");
            // loop to make a string of spaces with size size
            for (int i = 0; i < size; i++)
            {
                setWs[0] += " ";
            }
            // size of how many spaces to make between the price and quantity
            size = setW - price.ToString().Length;
            // add an empty string to the list of spaces
            setWs.Add("");
            // loop to make a string of spaces with size size
            for (int i = 0; i < size; i++)
            {
                setWs[1] += " ";
            }
            // return the record as a string
            return "   " + name + setWs[0] + "$" + price.ToString("#.##") + setWs[1] + quantity;
        }
    }
}

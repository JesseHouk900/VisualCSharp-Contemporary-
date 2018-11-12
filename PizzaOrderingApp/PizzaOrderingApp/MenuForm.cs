// pizza pizzaz: Prompt Pizzas
// form the user first sees that shows specialty options and create your own 
// option. Also contains the option to go to checkout
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingApp
{
    public partial class MenuForm : Form
    {
        static public Cart myCart;
        readonly private IReadOnlyCollection<Pizza> PizzaSpecials;
        readonly private IReadOnlyDictionary<string, int> SpecialPizzaNum;
        static public IReadOnlyDictionary<string, decimal> Toppings;
        public Pizza CurrentSpecialPizza;
        public MenuForm()
        {
            InitializeComponent();
            MouseEvents();
            // initialize the values of the toppings
            Dictionary<string, decimal> toppingPrices = new Dictionary<string, decimal>();
            toppingPrices["ham"] = .5m;
            toppingPrices["cheese"] = 0m;
            toppingPrices["salami"] = .5m;
            toppingPrices["sausage"] = .5m;
            toppingPrices["spinach"] = .5m;
            toppingPrices["chicken"] = .75m;
            toppingPrices["pepperoni"] = .5m;
            toppingPrices["mushrooms"] = .5m;
            toppingPrices["red onions"] = .5m;
            toppingPrices["double cheese"] = 1m;
            toppingPrices["black olives"] = .5m;
            toppingPrices["green bell peppers"] = .5m;
            Toppings = (IReadOnlyDictionary<string, decimal>)toppingPrices;
            if (myCart == null)
            {
                myCart = new Cart();
                myCart.PizzaList = new List<Pizza>();
            }
            Checkout_Label.Text = "Your current total is: $" + myCart.GetTotal().ToString("0.00");
            ArrayList pizzaInfo = LoadSpecials();
            if (pizzaInfo != null)
            {
                PizzaSpecials = (IReadOnlyCollection<Pizza>)pizzaInfo[0];
                SpecialPizzaNum = (IReadOnlyDictionary<string, int>)pizzaInfo[1];
            }
            Speciality_ComboBox.Items.Add("None");
            for (int i = 0; i < PizzaSpecials.Count(); i++)
            {
                Speciality_ComboBox.Items.Add(PizzaSpecials.ElementAt(i).Name);
            }
            // set the locations of the controls to be relative to one another
            Company_Label.Location = new Point((this.Size.Width / 2) -
                (Company_Label.Size.Width / 2), Company_Label.Location.Y);
            SpecialityPizza_GroupBox.Location = new Point(Company_Label.Location.X -
                (SpecialityPizza_GroupBox.Size.Width / 2), SpecialityPizza_GroupBox.Location.Y);
            Speciality_Label.Location = new Point((SpecialityPizza_GroupBox.Size.Width / 2) -
                (Speciality_Label.Size.Width / 2), 0);
            CreateYourOwn_Button.Location = new Point(Company_Label.Location.X +
                Company_Label.Size.Width - (CreateYourOwn_Button.Size.Width / 2),
                SpecialityPizza_GroupBox.Location.Y);
            Checkout_Button.Location = new Point(CreateYourOwn_Button.Location.X +
                (CreateYourOwn_Button.Size.Width / 2) - (Checkout_Button.Size.Width / 2),
                ((2 * SpecialityPizza_GroupBox.Location.Y) + Add_Button.Location.Y +
                SpecialityPizza_GroupBox.Size.Height) / 2);
            Checkout_Label.Location = new Point(CreateYourOwn_Button.Location.X +
                (CreateYourOwn_Button.Size.Width / 2) - (Checkout_Label.Size.Width / 2),
                SpecialityPizzaCost_Label.Location.Y + SpecialityPizza_GroupBox.Location.Y);
            // default the radio buttons to be disabled
            SIZE_Personal_radioButton.Enabled = false;
            SIZE_Small_radioButton.Enabled = false;
            SIZE_Medium_radioButton.Enabled = false;
            SIZE_Large_radioButton.Enabled = false;
        }

        private void MouseEvents()
        {
            // add an event to the size radio buttons
            SIZE_Personal_radioButton.MouseDown += new MouseEventHandler(
                SpecialityPizzaSize_CheckChanged);
            SIZE_Small_radioButton.MouseDown += new MouseEventHandler(
                SpecialityPizzaSize_CheckChanged);
            SIZE_Medium_radioButton.MouseDown += new MouseEventHandler(
                SpecialityPizzaSize_CheckChanged);
            SIZE_Large_radioButton.MouseDown += new MouseEventHandler(
                SpecialityPizzaSize_CheckChanged);
        }
        // read the specials from a file, file structure is discussed below
        static public ArrayList LoadSpecials()
        {
            // list of pizzas
            List<Pizza> specialPizzas = new List<Pizza>();
            // dictionary that associates pizza names with indexes in specialPizzas
            Dictionary<string, int> pizzaNums = new Dictionary<string, int>();
            try
            {
                string line;
                int i = -1;
                // reading from input file that should look like 
                // Pizza Name Goes Here
                // $10
                // Specialty Pizza 2
                // $20.34
                //
                // Below is a figure of the pizzas read in from the sample data above
                //        Pizza Name ->               1                           2
                //             Pizza ->     Pizza Name Goes Here    |    Speciality Pizza 2
                //                     ----------------------------------------------------------
                //             Price ->              10             |           20.34
                StreamReader fin = new StreamReader(new FileStream(Directory.GetCurrentDirectory() + "\\SpecialPizzas.txt", FileMode.Open));
                while ((line = fin.ReadLine()) != null)
                {
                    switch (line[0])
                    {
                        case '$':
                            specialPizzas[i].Price = decimal.Parse(line.Split('$')[1]);
                            break;
                        default:
                            i++;
                            specialPizzas.Add(new Pizza(line));
                            pizzaNums[line] = i;
                            specialPizzas[i].Name = line;
                            break;
                    }
                }
                fin.Close();
                return new ArrayList(2) { specialPizzas.AsReadOnly(),
                    (IReadOnlyDictionary<string, int>)pizzaNums};
            }
            catch (FileNotFoundException)
            {
                DialogResult result = MessageBox.Show("Sorry, the Special Pizzas were not found", "Missing File", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                switch (result)
                {
                    case DialogResult.Retry:
                        return LoadSpecials();
                    case DialogResult.Cancel:
                        return new ArrayList();
                    default:
                        return new ArrayList();
                }
            }
        }
        // event for if the size of the speciality pizza is changed
        public void SpecialityPizzaSize_CheckChanged(object sender, MouseEventArgs e)
        {
            specialityPizzaSize_CheckChanged(sender);
            SpecialityPizzaCost_Label.Text = "$" + CurrentSpecialPizza.Price.ToString("0.00");
        }
        // event for when the user clicks the add to cart button
        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add" +
                " a " + CurrentSpecialPizza.Name + " pizza to your order?",
                "Confirm Pizza Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    myCart.PizzaList.Add(new Pizza(CurrentSpecialPizza));
                    Checkout_Label.Text = "Your current total is: $" + myCart.GetTotal().ToString("0.00");
                    break;
                case DialogResult.No:
                    Speciality_ComboBox.SelectedIndex = 0;
                    SIZE_Medium_radioButton.Checked = true;
                    break;
            }
        }
        // event for when the type of speciality is changed
        private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if none is selected, 
            if ((string)((ComboBox)sender).SelectedItem == "None")
            {
                // restore everything to default and disable the radio buttons
                SIZE_Personal_radioButton.Enabled = false;
                SIZE_Personal_radioButton.Checked = false;
                SIZE_Small_radioButton.Enabled = false;
                SIZE_Small_radioButton.Checked = false;
                SIZE_Medium_radioButton.Enabled = false;
                SIZE_Medium_radioButton.Checked = false;
                SIZE_Large_radioButton.Enabled = false;
                SIZE_Large_radioButton.Checked = false;
            }
            else
            {
                // get the index of the selected pizza
                int selectedPizzaIndex = SpecialPizzaNum[(string)((ComboBox)sender).SelectedItem];
                // save the selected pizza as CurrentSpecialPizza
                CurrentSpecialPizza = new Pizza(PizzaSpecials.ElementAt(selectedPizzaIndex));
                // ensure the size is correct and alter the price as appropriate
                specialityPizzaSize_CheckChanged(CurrentSpecialPizza.Name);
                // update the label for the user
                SpecialityPizzaCost_Label.Text = "$" + CurrentSpecialPizza.Price.ToString("0.00");
                // allow all buttons to be selectable
                SIZE_Personal_radioButton.Enabled = true;
                SIZE_Small_radioButton.Enabled = true;
                SIZE_Medium_radioButton.Enabled = true;
                SIZE_Large_radioButton.Enabled = true;
                // when the user selects a pizza, default the choice to large
                SIZE_Large_radioButton.Checked = true;
            }
        }
        private void CreateYourOwnButton_Click(object sender, EventArgs e)
        {
            CustomizePizzaForm form = new CustomizePizzaForm();
            form.Show();
            this.Hide();
        }
        // event for when the user wants to go to place their order
        private void Checkout_Button_Click(object sender, EventArgs e)
        {
            CartForm form = new CartForm();
            form.Show();
            this.Hide();
        }
        // 
        static public void radioButton_CheckChanged(object sender, Pizza p, 
            Label l = null)
        {
            // break up the name of the radio button
            string[] parts = ((RadioButton)sender).Name.Split('_');
            // the type of the pizza is the second to last element in the split
            string type = parts[parts.Length - 2];
            // switch on the 
            switch (parts[parts.Length - 3])
            {
                case "SIZE":
                    p.Crust = type;
                    switch (type)
                    {
                        case "Personal":
                            p.BasePrice = 6m;
                            break;
                        case "Small":
                            p.BasePrice = 7m;
                            break;
                        case "Medium":
                            p.BasePrice = 8m;
                            break;
                        case "Large":
                            p.BasePrice = 9m;
                            break;
                    }
                    p.Price = p.GetTotalPrice();
                    if (l != null)
                    {
                        l.Text = "Total Price: $" + p.Price.ToString("0.00");

                    }
                    break;
                case "SAUCE":
                    p.Sauce = type + " sauce";
                    break;
            }
        }
        // method used when Size is directly changed by the user and when 
            // the type of pizza is changed. Both set the size of the pizza
            // and configure the price
        private void specialityPizzaSize_CheckChanged(object sender)
        {
            if (CurrentSpecialPizza != null)
            {
                string text;
                // if the object sent in is a radio button, this happens with a
                    // change in the size
                if (sender is RadioButton)
                {
                    text = ((RadioButton)sender).Text;
                    ((RadioButton)sender).Checked = true;
                }
                // else the object is assumed to be a string, happens when
                    // speciality is changed and size of pizza is passed
                    // directly
                else
                {
                    text = sender.ToString();
                }
                switch (text)
                {
                    case "Personal":
                        CurrentSpecialPizza.Crust = "Personal";
                        CurrentSpecialPizza.Price = PizzaSpecials.ElementAt(
                            SpecialPizzaNum[CurrentSpecialPizza.Name]).Price * 0.6m;
                        break;
                    case "Small":
                        CurrentSpecialPizza.Crust = "Small";
                        CurrentSpecialPizza.Price = PizzaSpecials.ElementAt(
                            SpecialPizzaNum[CurrentSpecialPizza.Name]).Price * 0.8m;
                        break;
                    case "Medium":
                        CurrentSpecialPizza.Crust = "Medium";
                        CurrentSpecialPizza.Price = PizzaSpecials.ElementAt(
                            SpecialPizzaNum[CurrentSpecialPizza.Name]).Price * 0.9m;
                        break;
                    case "Large":
                        CurrentSpecialPizza.Crust = "Large";
                        CurrentSpecialPizza.Price = PizzaSpecials.ElementAt(
                            SpecialPizzaNum[CurrentSpecialPizza.Name]).Price;
                        break;
                }
            }
        }
    }
}

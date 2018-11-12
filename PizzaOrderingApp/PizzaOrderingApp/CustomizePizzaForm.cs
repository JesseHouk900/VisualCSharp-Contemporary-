using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PizzaOrderingApp
{
    public partial class CustomizePizzaForm : Form
    {
        static public IReadOnlyDictionary<string, decimal> Toppings;
        public Pizza CustomPizza;
        public CustomizePizzaForm()
        {
            InitializeComponent();
            MouseEvents();
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
            CustomPizza = new Pizza();
            LoadImageLocations();
            SIZE_Medium_radioButton.Checked = true;
            SAUCE_Tomato_radioButton.Checked = true;
            radioButton_CheckChanged(SAUCE_Tomato_radioButton);
            ChangeToppings(FULL_Cheese_PictureBox, LEFT_Cheese_PictureBox, RIGHT_Cheese_PictureBox);
            CustomPizza.Price = CustomPizza.GetTotalPrice();
            PizzaPrice_Label.Text = "Total Price: $" + CustomPizza.Price.ToString("0.00");
        }

        private void MouseEvents()
        {
            FULL_Cheese_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_DoubleCheese_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_Pepperoni_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_Chicken_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_Sausage_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_Salami_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_Ham_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_Mushrooms_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_BlackOlives_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_Spinach_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_RedOnions_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            FULL_GreenBellPeppers_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);

            LEFT_Cheese_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_DoubleCheese_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_Pepperoni_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_Chicken_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_Sausage_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_Salami_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_Ham_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_Mushrooms_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_BlackOlives_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_Spinach_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_RedOnions_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            LEFT_GreenBellPeppers_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);

            RIGHT_Cheese_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_DoubleCheese_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_Pepperoni_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_Chicken_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_Sausage_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_Salami_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_Ham_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_Mushrooms_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_BlackOlives_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_Spinach_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_RedOnions_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);
            RIGHT_GreenBellPeppers_PictureBox.MouseClick += new MouseEventHandler(AddTopping_PictureBoxClicked);

            SIZE_Personal_radioButton.MouseClick += new MouseEventHandler(RadioButton_CheckChanged);
            SIZE_Small_radioButton.MouseClick += new MouseEventHandler(RadioButton_CheckChanged);
            SIZE_Medium_radioButton.MouseClick += new MouseEventHandler(RadioButton_CheckChanged);
            SIZE_Large_radioButton.MouseClick += new MouseEventHandler(RadioButton_CheckChanged);
            SAUCE_Tomato_radioButton.MouseClick += new MouseEventHandler(RadioButton_CheckChanged);
            SAUCE_Alfredo_radioButton.MouseClick += new MouseEventHandler(RadioButton_CheckChanged);
        }

        private void LoadImageLocations()
        {
            FULL_Cheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_DoubleCheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Pepperoni_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Chicken_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Sausage_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Salami_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Ham_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Mushrooms_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_BlackOlives_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Spinach_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_RedOnions_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_GreenBellPeppers_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_FullPizza.jpg";

            LEFT_Cheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_DoubleCheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Pepperoni_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Chicken_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Sausage_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Salami_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Ham_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Mushrooms_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_BlackOlives_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Spinach_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_RedOnions_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_GreenBellPeppers_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_LeftSidePizza.jpg";

            RIGHT_Cheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_DoubleCheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Pepperoni_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Chicken_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Sausage_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Salami_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Ham_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Mushrooms_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_BlackOlives_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Spinach_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_RedOnions_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_GreenBellPeppers_PictureBox.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_RightSidePizza.jpg";
        }

        private void AddTopping_PictureBoxClicked(object sender, MouseEventArgs e)
        {
            string[] pieces;
            pieces = ((PictureBox)sender).Name.Split('_');
            bool wasChecked;
            switch (pieces[0])
            {
                case "FULL":
                    switch (pieces[1])
                    {
                        case "Cheese":
                            wasChecked = ChangeToppings(FULL_Cheese_PictureBox, LEFT_Cheese_PictureBox, RIGHT_Cheese_PictureBox);
                            AddTopping("cheese", -1, 'W', wasChecked);
                            break;
                        case "DoubleCheese":
                            wasChecked = ChangeToppings(FULL_DoubleCheese_PictureBox, LEFT_DoubleCheese_PictureBox, RIGHT_DoubleCheese_PictureBox);
                            AddTopping("double cheese", -1, 'W', wasChecked);
                            break;
                        case "Pepperoni":
                            wasChecked = ChangeToppings(FULL_Pepperoni_PictureBox, LEFT_Pepperoni_PictureBox, RIGHT_Pepperoni_PictureBox);
                            AddTopping("pepperoni", -1, 'W', wasChecked);
                            break;
                        case "Chicken":
                            wasChecked = ChangeToppings(FULL_Chicken_PictureBox, LEFT_Chicken_PictureBox, RIGHT_Chicken_PictureBox);
                            AddTopping("chicken", -1, 'W', wasChecked);
                            break;
                        case "Sausage":
                            wasChecked = ChangeToppings(FULL_Sausage_PictureBox, LEFT_Sausage_PictureBox, RIGHT_Sausage_PictureBox);
                            AddTopping("sausage", -1, 'W', wasChecked);
                            break;
                        case "Salami":
                            wasChecked = ChangeToppings(FULL_Salami_PictureBox, LEFT_Salami_PictureBox, RIGHT_Salami_PictureBox);
                            AddTopping("salami", -1, 'W', wasChecked);
                            break;
                        case "Ham":
                            wasChecked = ChangeToppings(FULL_Ham_PictureBox, LEFT_Ham_PictureBox, RIGHT_Ham_PictureBox);
                            AddTopping("ham", -1, 'W', wasChecked);
                            break;
                        case "Mushrooms":
                            wasChecked = ChangeToppings(FULL_Mushrooms_PictureBox, LEFT_Mushrooms_PictureBox, RIGHT_Mushrooms_PictureBox);
                            AddTopping("mushrooms", -1, 'W', wasChecked);
                            break;
                        case "BlackOlives":
                            wasChecked = ChangeToppings(FULL_BlackOlives_PictureBox, LEFT_BlackOlives_PictureBox, RIGHT_BlackOlives_PictureBox);
                            AddTopping("black olives", -1, 'W', wasChecked);
                            break;
                        case "Spinach":
                            wasChecked = ChangeToppings(FULL_Spinach_PictureBox, LEFT_Spinach_PictureBox, RIGHT_Spinach_PictureBox);
                            AddTopping("spinach", -1, 'W', wasChecked);
                            break;
                        case "GreenBellPeppers":
                            wasChecked = ChangeToppings(FULL_GreenBellPeppers_PictureBox, LEFT_GreenBellPeppers_PictureBox, RIGHT_GreenBellPeppers_PictureBox);
                            AddTopping("green bell peppers", -1, 'W', wasChecked);
                            break;
                        case "RedOnions":
                            wasChecked = ChangeToppings(FULL_RedOnions_PictureBox, LEFT_RedOnions_PictureBox, RIGHT_RedOnions_PictureBox);
                            AddTopping("red onions", -1, 'W', wasChecked);
                            break;
                    }
                    break;
                case "LEFT":
                    switch (pieces[1])
                    {
                        case "Cheese":
                            wasChecked = ChangeToppings(LEFT_Cheese_PictureBox, FULL_Cheese_PictureBox, RIGHT_Cheese_PictureBox);
                            AddTopping("cheese", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "DoubleCheese":
                            wasChecked = ChangeToppings(LEFT_DoubleCheese_PictureBox, FULL_DoubleCheese_PictureBox, RIGHT_DoubleCheese_PictureBox);
                            AddTopping("double cheese", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "Pepperoni":
                            wasChecked = ChangeToppings(LEFT_Pepperoni_PictureBox, FULL_Pepperoni_PictureBox, RIGHT_Pepperoni_PictureBox);
                            AddTopping("pepperoni", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "Chicken":
                            wasChecked = ChangeToppings(LEFT_Chicken_PictureBox, FULL_Chicken_PictureBox, RIGHT_Chicken_PictureBox);
                            AddTopping("chicken", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "Sausage":
                            wasChecked = ChangeToppings(LEFT_Sausage_PictureBox, FULL_Sausage_PictureBox, RIGHT_Sausage_PictureBox);
                            AddTopping("sausage", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "Salami":
                            wasChecked = ChangeToppings(LEFT_Salami_PictureBox, FULL_Salami_PictureBox, RIGHT_Salami_PictureBox);
                            AddTopping("salami", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "Ham":
                            wasChecked = ChangeToppings(LEFT_Ham_PictureBox, FULL_Ham_PictureBox, RIGHT_Ham_PictureBox);
                            AddTopping("ham", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "Mushrooms":
                            wasChecked = ChangeToppings(LEFT_Mushrooms_PictureBox, FULL_Mushrooms_PictureBox, RIGHT_Mushrooms_PictureBox);
                            AddTopping("mushrooms", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "BlackOlives":
                            wasChecked = ChangeToppings(LEFT_BlackOlives_PictureBox, FULL_BlackOlives_PictureBox, RIGHT_BlackOlives_PictureBox);
                            AddTopping("black olives", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "Spinach":
                            wasChecked = ChangeToppings(LEFT_Spinach_PictureBox, FULL_Spinach_PictureBox, RIGHT_Spinach_PictureBox);
                            AddTopping("spinach", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "GreenBellPeppers":
                            wasChecked = ChangeToppings(LEFT_GreenBellPeppers_PictureBox, FULL_GreenBellPeppers_PictureBox, RIGHT_GreenBellPeppers_PictureBox);
                            AddTopping("green bell peppers", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                        case "RedOnions":
                            wasChecked = ChangeToppings(LEFT_RedOnions_PictureBox, FULL_RedOnions_PictureBox, RIGHT_RedOnions_PictureBox);
                            AddTopping("red onions", CustomPizza.LeftToppings.Count - 1, 'L', wasChecked);
                            break;
                    }
                    break;
                case "RIGHT":
                    switch (pieces[1])
                    {
                        case "Cheese":
                            wasChecked = ChangeToppings(RIGHT_Cheese_PictureBox, FULL_Cheese_PictureBox, LEFT_Cheese_PictureBox);
                            AddTopping("cheese", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "DoubleCheese":
                            wasChecked = ChangeToppings(RIGHT_DoubleCheese_PictureBox, FULL_DoubleCheese_PictureBox, LEFT_DoubleCheese_PictureBox);
                            AddTopping("double cheese", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "Pepperoni":
                            wasChecked = ChangeToppings(RIGHT_Pepperoni_PictureBox, FULL_Pepperoni_PictureBox, LEFT_Pepperoni_PictureBox);
                            AddTopping("pepperoni", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "Chicken":
                            wasChecked = ChangeToppings(RIGHT_Chicken_PictureBox, FULL_Chicken_PictureBox, LEFT_Chicken_PictureBox);
                            AddTopping("chicken", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "Sausage":
                            wasChecked = ChangeToppings(RIGHT_Sausage_PictureBox, FULL_Sausage_PictureBox, LEFT_Sausage_PictureBox);
                            AddTopping("sausage", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "Salami":
                            wasChecked = ChangeToppings(RIGHT_Salami_PictureBox, FULL_Salami_PictureBox, LEFT_Salami_PictureBox);
                            AddTopping("salami", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "Ham":
                            wasChecked = ChangeToppings(RIGHT_Ham_PictureBox, FULL_Ham_PictureBox, LEFT_Ham_PictureBox);
                            AddTopping("ham", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "Mushrooms":
                            wasChecked = ChangeToppings(RIGHT_Mushrooms_PictureBox, FULL_Mushrooms_PictureBox, LEFT_Mushrooms_PictureBox);
                            AddTopping("mushrooms", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "BlackOlives":
                            wasChecked = ChangeToppings(RIGHT_BlackOlives_PictureBox, FULL_BlackOlives_PictureBox, LEFT_BlackOlives_PictureBox);
                            AddTopping("black olives", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "Spinach":
                            wasChecked = ChangeToppings(RIGHT_Spinach_PictureBox, FULL_Spinach_PictureBox, LEFT_Spinach_PictureBox);
                            AddTopping("spinach", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "GreenBellPeppers":
                            wasChecked = ChangeToppings(RIGHT_GreenBellPeppers_PictureBox, FULL_GreenBellPeppers_PictureBox, LEFT_GreenBellPeppers_PictureBox);
                            AddTopping("green bell peppers", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                        case "RedOnions":
                            wasChecked = ChangeToppings(RIGHT_RedOnions_PictureBox, FULL_RedOnions_PictureBox, LEFT_RedOnions_PictureBox);
                            AddTopping("red onions", CustomPizza.RightToppings.Count - 1, 'R', wasChecked);
                            break;
                    }
                    break;
            }
        }

        private bool ChangeToppings(PictureBox a, PictureBox b, PictureBox c)
        {
            string img = a.ImageLocation.Split('.')[0].Split('_')[1];
            if (a.ImageLocation.Contains("Unchecked"))
            {
                a.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Checked_" + img + ".jpg");
                a.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Checked_" + img + ".jpg";
                img = b.ImageLocation.Split('.')[0].Split('_')[1];
                b.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg");
                b.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg";
                img = c.ImageLocation.Split('.')[0].Split('_')[1];
                c.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg");
                c.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg";
                return false;
            }
            else
            {
                a.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg");
                return true;
            }
        }

        private void AddCustomPizza_Button_Click(object sender, EventArgs e)
        {
            MenuForm.myCart.PizzaList.Add(new Pizza(CustomPizza));
            MenuForm form = new MenuForm();
            form.Show();
            this.Hide();
        }

        private void RadioButton_CheckChanged(object sender, MouseEventArgs e)
        {
            radioButton_CheckChanged(sender);
        }

        private void radioButton_CheckChanged(object sender)
        {
            string[] parts = ((RadioButton)sender).Name.Split('_');
            string type = parts[parts.Length - 2];
            switch (parts[parts.Length - 3])
            {
                case "SIZE":
                    CustomPizza.Crust = type;
                    switch (type)
                    {
                        case "Personal":
                            CustomPizza.BasePrice = 6m;
                            break;
                        case "Small":
                            CustomPizza.BasePrice = 7m;
                            break;
                        case "Medium":
                            CustomPizza.BasePrice = 8m;
                            break;
                        case "Large":
                            CustomPizza.BasePrice = 9m;
                            break;
                    }
                    CustomPizza.Price = CustomPizza.GetTotalPrice();
                    PizzaPrice_Label.Text = "Total Price: $" + CustomPizza.Price.ToString("0.00");
                    break;
                case "SAUCE":
                    CustomPizza.Sauce = type + " sauce";
                    break;
            }
        }

        public void AddTopping(string top, int i, char side, bool wasChecked)
        {
            if (Contains(CustomPizza.LeftToppings, top))
            {
                CustomPizza.LeftToppings.Remove(top);
            }
            if (Contains(CustomPizza.RightToppings, top))
            {
                CustomPizza.RightToppings.Remove(top);
            }
            switch (side)
            {
                case 'W':
                    if (!wasChecked)
                    {
                        int index = CustomPizza.LeftToppings.Count + i;
                        CustomPizza.LeftToppings.Insert(Math.Max(index, 0), top);
                        index = CustomPizza.RightToppings.Count + i;
                        CustomPizza.RightToppings.Insert(Math.Max(index, 0), top);
                    }
                    break;
                case 'L':
                    if (!wasChecked)
                    {
                        CustomPizza.LeftToppings.Insert(Math.Max(i, 0), top);
                    }
                    break;
                case 'R':
                    if (!wasChecked)
                    {
                        CustomPizza.RightToppings.Insert(Math.Max(i, 0), top);
                    }
                    break;
            }
            CustomPizza.Price = CustomPizza.GetTotalPrice();
            PizzaPrice_Label.Text = "Total Price: $" + CustomPizza.Price.ToString("0.00");
        }

        public bool Contains(List<string> L, string item)
        {
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

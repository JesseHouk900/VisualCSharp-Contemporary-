/*
 * Form wherein the user creates a pizza how they want. Utilizes PictureBox
 *  control for selecting which halves the toppings should be on. Pizza sauce
 *  and pizza size are determined with the RadioButton control.
 * 
 *  Jesse Houk
 * 
 */ 
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
        // object for the pizza being created by the user
        public Pizza CustomPizza;
        // Constructor that initializes default values
        public CustomizePizzaForm()
        {
            InitializeComponent();
            // establish what the mouse events are for the picture boxes
            MouseEvents();
            // load the ImageLocations for the images of the picture boxes
            LoadImageLocations();
            // make a default pizza to start the user off with
            CustomPizza = new Pizza();
            // default check the medium size radio button to match the default 
                // pizza
            SIZE_Medium_radioButton.Checked = true;
            // default check the tomato sauce radio button to match the default 
                // pizza
            SAUCE_Tomato_radioButton.Checked = true;
            // ensure prices are set appropriately based on the sauce defaulted to
            MenuForm.radioButton_CheckChanged(SAUCE_Tomato_radioButton,
                CustomPizza, PizzaPrice_Label);
            // default cheese to be on the whole pizza by to match the default
                // pizza
            ChangeToppings(FULL_Cheese_PictureBox, LEFT_Cheese_PictureBox, RIGHT_Cheese_PictureBox);
            // save the price of the custom pizza by caluclating the total price
            CustomPizza.Price = CustomPizza.GetTotalPrice();
            // display the total price of the pizza
            PizzaPrice_Label.Text = "Total Price: $" + CustomPizza.Price.ToString("0.00");
        }
        // Set up the event handlers for every mouse event that needs to be
            // handled
        private void MouseEvents()
        {
            // add AddTopping_PictureBoxClicked event to the event handlers of 
                // all of the full topping picture boxes
            FULL_Cheese_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_DoubleCheese_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_Pepperoni_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_Chicken_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_Sausage_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_Salami_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_Ham_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_Mushrooms_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_BlackOlives_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_Spinach_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_RedOnions_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            FULL_GreenBellPeppers_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);

            // add AddTopping_PictureBoxClicked event to the event handlers of 
                // all of the left half topping picture boxes
            LEFT_Cheese_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_DoubleCheese_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_Pepperoni_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_Chicken_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_Sausage_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_Salami_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_Ham_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_Mushrooms_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_BlackOlives_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_Spinach_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_RedOnions_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            LEFT_GreenBellPeppers_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);

            // add AddTopping_PictureBoxClicked event to the event handlers of 
                // all of the right half topping picture boxes
            RIGHT_Cheese_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_DoubleCheese_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_Pepperoni_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_Chicken_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_Sausage_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_Salami_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_Ham_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_Mushrooms_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_BlackOlives_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_Spinach_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_RedOnions_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);
            RIGHT_GreenBellPeppers_PictureBox.MouseClick += new MouseEventHandler(
                AddTopping_PictureBoxClicked);

            // add RadioButton_CheckChanged event to the event handlers of all 
                // of the size radio buttons
            SIZE_Personal_radioButton.MouseClick += new MouseEventHandler(
                RadioButton_CheckChanged);
            SIZE_Small_radioButton.MouseClick += new MouseEventHandler(
                RadioButton_CheckChanged);
            SIZE_Medium_radioButton.MouseClick += new MouseEventHandler(
                RadioButton_CheckChanged);
            SIZE_Large_radioButton.MouseClick += new MouseEventHandler(
                RadioButton_CheckChanged);

            // add RadioButton_CheckChanged event to the event handlers of all
                // of the sauce radio buttons
            SAUCE_Tomato_radioButton.MouseClick += new MouseEventHandler(
                RadioButton_CheckChanged);
            SAUCE_Alfredo_radioButton.MouseClick += new MouseEventHandler(
                RadioButton_CheckChanged);
        }
        // Set up the ImageLocations for all of the PictureBoxes to come from 
            // bin/Debug/Images
        private void LoadImageLocations()
        {
            // set the ImageLocations of the full picture boxes
            FULL_Cheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_DoubleCheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Pepperoni_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Chicken_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Sausage_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Salami_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Ham_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Mushrooms_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_BlackOlives_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_Spinach_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_RedOnions_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";
            FULL_GreenBellPeppers_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_FullPizza.jpg";

            // set the ImageLocations of the left half picture boxes
            LEFT_Cheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_DoubleCheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Pepperoni_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Chicken_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Sausage_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Salami_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Ham_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Mushrooms_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_BlackOlives_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_Spinach_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_RedOnions_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";
            LEFT_GreenBellPeppers_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_LeftSidePizza.jpg";

            // set the ImageLocations of the right half picture boxes
            RIGHT_Cheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_DoubleCheese_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Pepperoni_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Chicken_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Sausage_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Salami_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Ham_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Mushrooms_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_BlackOlives_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_Spinach_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_RedOnions_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
            RIGHT_GreenBellPeppers_PictureBox.ImageLocation = Directory.GetCurrentDirectory()
                + "\\Images\\Unchecked_RightSidePizza.jpg";
        }
        // event for when a topping is added to the CustomPizza from picture boxes
        private void AddTopping_PictureBoxClicked(object sender, MouseEventArgs e)
        {
            // an array to hold the result of the sender's name that is split
            string[] pieces;
            // split the name of the PictureBox on an underscore, _
            pieces = ((PictureBox)sender).Name.Split('_');
            // determined by whether the picture box was previously checked or not
            bool wasChecked;
            // switch on the first value of the split name which will be either
                // FULL, LEFT, or RIGHT
            switch (pieces[0])
            {
                case "FULL":
                    // switch on the second value of the split name, the topping
                        // which will be either Cheese, DoubleCheese, Pepperoni,
                        // Sausage, Chicken, Salami, Ham, Mushrooms, BlackOlives,
                        // GreenBellPeppers, RedOnions, or Spinach. This follows
                        // for all cases of pieces[0].
                    switch (pieces[1])
                    {
                        case "Cheese":
                            // Here, ChangeToppings changes the PictureBox that 
                                // looks selected to the one selected, FULL_Cheese
                                // and deselects the others, returning if the one
                                // selected was selected prior to being selected.
                                // This follows for all topping selections.
                            wasChecked = ChangeToppings(FULL_Cheese_PictureBox, LEFT_Cheese_PictureBox, RIGHT_Cheese_PictureBox);
                            // Here, AddTopping adds cheese to the whole pizza.
                                // This follows for all topping selections
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
        // taking in, first, the PictureBox selected, then the two counterpart
            // PictureBoxes, "deselect" the counterparts and "select" the selected
            // PictureBox. return whether the "selected" PictureBox was already 
            //selected or not
        private bool ChangeToppings(PictureBox a, PictureBox b, PictureBox c)
        {
            // split on the ImageLocation of the selected PictureBox to get 
                // the name of the PictureBox
            string img = a.ImageLocation.Split('.')[0].Split('_')[1];
            // if the image was unchecked...
            if (a.ImageLocation.Contains("Unchecked"))
            {
                // check the "selected" picture box
                a.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Checked_" + img + ".jpg");
                a.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Checked_" + img + ".jpg";
                // and do the same for the other PictureBoxes
                img = b.ImageLocation.Split('.')[0].Split('_')[1];
                b.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg");
                b.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg";
                img = c.ImageLocation.Split('.')[0].Split('_')[1];
                c.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg");
                c.ImageLocation = Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg";
                // say the image was unchecked
                return false;
            }
            else // the PictureBox was checked...
            {
                // so make the picture box unchecked
                a.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\Unchecked_" + img + ".jpg");
                // say the image was checked
                return true;
            }
        }
        //event called when the user wants to add a pizza to their order
        private void AddCustomPizza_Button_Click(object sender, EventArgs e)
        {
            // prompt the user for comfirmation of their decision
            DialogResult result = MessageBox.Show("Are you sure you want to add this" +
                " pizza to your cart?", "Add Pizza", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            // if the user says OK...
            if (result == DialogResult.OK)
            {
                // add the pizza to their cart
                MenuForm.myCart.PizzaList.Add(new Pizza(CustomPizza));
                // and change the form back to the MenuForm
                MenuForm form = new MenuForm();
                form.Show();
                this.Hide();

            }
        }
        // event for when a radio button is checked
        private void RadioButton_CheckChanged(object sender, MouseEventArgs e)
        {
            // use the static method from MenuForm that handles radio buttons
                // being checked as they are the same on the menu and custmmize
                // forms. In addition to the sender, pass in the pizza being alterd,
                // CustomPizza, and the label that will be updated
            MenuForm.radioButton_CheckChanged(sender, CustomPizza, PizzaPrice_Label);
        }
        // add a topping to a pizza taking in 
            // the name of the topping as a string
            // a value to help index as an int
            // a value for which side the topping is to go on as a char, valid
                // values are W for whole pizza, L for left half, R for right half
            // the value of whether the topping on the side was checked in the 
                // gui prior to the current selection
        public void AddTopping(string top, int i, char side, bool wasChecked)
        {
            // the following two if statement say, if the topping is on a
                // particular side of the pizza, remove it
            if (Contains(CustomPizza.LeftToppings, top))
            {
                CustomPizza.LeftToppings.Remove(top);
            }
            if (Contains(CustomPizza.RightToppings, top))
            {
                CustomPizza.RightToppings.Remove(top);
            }
            // switch on which side the topping goes onto the pizza
            switch (side)
            {
                case 'W':
                    // if the picture box is now being selected...
                    if (!wasChecked)
                    {
                        // get the last index of the left side of the pizza
                        int index = CustomPizza.LeftToppings.Count + i;
                        // and insert the topping there. The same logic
                            // follows for when a topping is added to just 
                            // the left side of a pizza
                        CustomPizza.LeftToppings.Insert(Math.Max(index, 0), top);
                        // get the last index of the right side of the pizza
                        index = CustomPizza.RightToppings.Count + i;
                        // and insert the topping there. The same logic
                        // follows for when a topping is added to just 
                        // the right side of a pizza
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
            // update the pizza price
            CustomPizza.Price = CustomPizza.GetTotalPrice();
            // and display the price to the user
            PizzaPrice_Label.Text = "Total Price: $" + CustomPizza.Price.ToString("0.00");
        }
        // determine if a string is in a list
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

        private void Back_Button_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            this.Hide();
        }
    }
}

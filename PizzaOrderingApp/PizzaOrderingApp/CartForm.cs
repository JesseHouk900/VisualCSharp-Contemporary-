/*
 * 
 * 
 * Jesse Houk
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

namespace PizzaOrderingApp
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
            DrawOnPanel();
        }
        private void DrawOnPanel()
        {
            int y_offset = 0;
            decimal cartCost = 0.00m;
            for (int i = 0; i < MenuForm.myCart.PizzaList.Count; i++)
            {
                if (MenuForm.myCart.PizzaList[i].Name != "Custom")
                {
                    Label sPizza = new Label();
                    sPizza.Text = "A " + MenuForm.myCart.PizzaList[i].Crust.ToLower() + 
                        " size, " + MenuForm.myCart.PizzaList[i].Name + " pizza";
                    sPizza.Location = new Point(15, y_offset);
                    sPizza.AutoSize = true;
                    PizzaList_Panel.Controls.Add(sPizza);
                    Label pizzaCost = new Label();
                    // add the total price of each pizza to the price of the order
                    cartCost += MenuForm.myCart.PizzaList[i].Price;
                    // 
                    pizzaCost.Text = "$" + MenuForm.myCart.PizzaList[i].Price.ToString("0.00");
                    pizzaCost.Location = new Point(PizzaList_Panel.Size.Width - 175, y_offset);
                    pizzaCost.AutoSize = true;
                    PizzaList_Panel.Controls.Add(pizzaCost);
                    // make a delete button for each pizza
                    Button deletePizzaButton = new Button();
                    deletePizzaButton.Text = "Delete";
                    deletePizzaButton.Name = "deletePizza_Button_" + i;
                    deletePizzaButton.MouseClick += new MouseEventHandler(DeletePizza);
                    deletePizzaButton.Location = new Point(PizzaList_Panel.Size.Width - 100, y_offset);
                    deletePizzaButton.AutoSize = true;
                    PizzaList_Panel.Controls.Add(deletePizzaButton);
                    y_offset += 45;

                }
                else
                {
                    // print both sides of the pizza (PrintSide("left"...) recursively calls PrintSide("right"...))
                    y_offset = PrintSide("left", 15, y_offset, i); // - MenuForm.myCart.PizzaList[i].LeftToppings.Count * 25;
                                                                   // make a label for each pizza's cost
                    Label pizzaCost = new Label();
                    // add the total price of each pizza to the price of the order
                    cartCost += MenuForm.myCart.PizzaList[i].Price;
                    // 
                    pizzaCost.Text = "$" + MenuForm.myCart.PizzaList[i].Price.ToString("0.00");
                    pizzaCost.Location = new Point(PizzaList_Panel.Size.Width - 175, y_offset - 20);
                    pizzaCost.AutoSize = true;
                    PizzaList_Panel.Controls.Add(pizzaCost);
                    // make a delete button for each pizza
                    Button deletePizzaButton = new Button();
                    deletePizzaButton.Text = "Delete";
                    deletePizzaButton.Name = "deletePizza_Button_" + i;
                    deletePizzaButton.MouseClick += new MouseEventHandler(DeletePizza);
                    deletePizzaButton.Location = new Point(PizzaList_Panel.Size.Width - 100, y_offset - 20);
                    deletePizzaButton.AutoSize = true;
                    PizzaList_Panel.Controls.Add(deletePizzaButton);
                    y_offset += 45;
                }
            }
            Label subTotal = new Label();
            subTotal.Text = "Subtotal - $" + cartCost.ToString("0.00");
            subTotal.Location = new Point(ConfirmOrder_Button.Location.X - 75, ConfirmOrder_Button.Location.Y - 30);
            subTotal.AutoSize = true;
            Subtotal_Label.Text = "Subtotal - $" + MenuForm.myCart.GetTotal().ToString("0.00");
            //Subtotal_Label.Location = new Point(ConfirmOrder_Button.Location.X - 75, ConfirmOrder_Button.Location.Y - 30);
            //Subtotal_Label.AutoSize = true;
            this.Controls.Add(Subtotal_Label);
            Label totalCost = new Label();
            Total_Label.Text = "Total - $" + (MenuForm.myCart.GetTotal() * 1.08m).ToString("0.00");
            //Total_Label.Location = new Point(ConfirmOrder_Button.Location.X - 75, ConfirmOrder_Button.Location.Y);
            //Total_Label.AutoSize = true;
            this.Controls.Add(Total_Label);
        }

        private void DeletePizza(object sender, MouseEventArgs e)
        {
            int i = Int32.Parse(((Button)sender).Name.Split('_')[2]);
            MenuForm.myCart.PizzaList.RemoveAt(i);
            PizzaList_Panel.Controls.Clear();
            PizzaList_Panel.Update();
            DrawOnPanel();
            Subtotal_Label.Text = "Subtotal - $" + MenuForm.myCart.GetTotal().ToString("0.00");
            //Subtotal_Label.Location = new Point(ConfirmOrder_Button.Location.X - 75, ConfirmOrder_Button.Location.Y - 30);
            //Subtotal_Label.AutoSize = true;
            this.Controls.Add(Subtotal_Label);
            Label totalCost = new Label();
            Total_Label.Text = "Total - $" + (MenuForm.myCart.GetTotal() * 1.08m).ToString("0.00");
            //Total_Label.Location = new Point(ConfirmOrder_Button.Location.X - 75, ConfirmOrder_Button.Location.Y);
            //Total_Label.AutoSize = true;
            this.Controls.Add(Total_Label);
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            this.Hide();
        }

        private int PrintSide(string side, int x_off, int y_off, int i)
        {
            int lastIndex;
            Label pizzaLabel = new Label();
            if (side == "left")
            {
                pizzaLabel.Location = new Point(x_off, y_off); // - MenuForm.myCart.PizzaList[i].RightToppings.Count * 25;
                y_off += 25;
                pizzaLabel.Text = "A " + MenuForm.myCart.PizzaList[i].Crust.ToLower() +
                    " size, " + MenuForm.myCart.PizzaList[i].Sauce.ToLower() +
                    " pizza with" + Environment.NewLine + "    a left side of:" +
                    Environment.NewLine;
                y_off = PrintSide("right", 15 + (PizzaList_Panel.Size.Width / 2), y_off, i);

                lastIndex = MenuForm.myCart.PizzaList[i].LeftToppings.Count;
                for (int j = 0; j < lastIndex; j++)
                {
                    pizzaLabel.Text += " - " + MenuForm.myCart.PizzaList[i].LeftToppings[j] + Environment.NewLine;
                }
                pizzaLabel.AutoSize = true;
            }
            else if (side == "right")
            {
                pizzaLabel.Text += "and a right side of:" + Environment.NewLine;
                lastIndex = MenuForm.myCart.PizzaList[i].RightToppings.Count;
                for (int j = 0; j < lastIndex; j++)
                {
                    pizzaLabel.Text += " - " +
                        MenuForm.myCart.PizzaList[i].RightToppings[j] + Environment.NewLine;
                }
                pizzaLabel.Location = new Point(x_off, y_off); // - MenuForm.myCart.PizzaList[i].RightToppings.Count * 25;
                pizzaLabel.AutoSize = true;
            }
            PizzaList_Panel.Controls.Add(pizzaLabel);
            if (side == "left")
            {
                return y_off +
                    (Math.Max(MenuForm.myCart.PizzaList[i].LeftToppings.Count,
                    MenuForm.myCart.PizzaList[i].RightToppings.Count) * 25);
            }
            return y_off;
        }

        private void ConfirmOrder_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to place this order?",
                "Place Order?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Your order will be ready in 45-60 minutes",
                    "Order Placed");
            }
        }
    }
}

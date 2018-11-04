using System;
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
        public Pizza CurrentSpecialPizza;
        public MenuForm()
        {
            InitializeComponent();
            MouseEvents();
            myCart = new Cart();
            PizzaSpecials = LoadSpecials();
            CurrentSpecialPizza = new Pizza();
        }

        private void MouseEvents()
        {
            //SpecialityComboBox.SelectedIndexChanged += new MouseEventHandler(SpecialityComboBox_SelectedIndexChanged);
            SmallPizza_radioButton.MouseDown += new MouseEventHandler(SpecialityPizzaSize_CheckChanged);
            MediumPizza_radioButton.MouseDown += new MouseEventHandler(SpecialityPizzaSize_CheckChanged);
            LargePizza_radioButton.MouseDown += new MouseEventHandler(SpecialityPizzaSize_CheckChanged);

        }

        static public IReadOnlyCollection<Pizza> LoadSpecials()
        {
            List<Pizza> specialPizzas = new List<Pizza>();
            try
            {
                string line;
                int i = 0;
                // reading from input file that should look like 
                // Pizza Name Goes Here
                // $10
                // -Topping Name Goes Here
                // -Notice the absence of
                // -A space at the beginning
                // -Of the line
                // Specialty Pizza 2
                // $20.34
                // -The goods
                //
                // Below is a figure of the pizzas read in from the sample data above
                //
                //  Toppings   Pizza ->     Pizza Name Goes Here    |    Speciality Pizza 2
                //      |              ----------------------------------------------------------
                //      V                  Topping Name Goes Here   |         The goods
                //                          Notice the absence of   |
                //                        A space at the beginning  |
                //                               Of the line        |
                //
                // Price ->                            10                       20.34
                // NOTE: Using "The goods" as a topping input does not register as specific toppings.
                //      It just adds "The goods" as an individual topping.
                StreamReader fin = new StreamReader(new FileStream(Directory.GetCurrentDirectory() + "\\SpecialPizzas.txt", FileMode.Open));
                while ((line = fin.ReadLine()) != null)
                {
                    switch (line[0])
                    {
                        case '-':
                            specialPizzas[i].Toppings.Add(line.Split('-')[1]);
                            break;
                        case '$':
                            specialPizzas[i].Price = decimal.Parse(line.Split('$')[0]);
                            break;
                        default:
                            specialPizzas.Add(new Pizza(line));
                            if (i != 0)
                            {
                                i++;
                            }
                            break;
                    }
                }
                return specialPizzas.AsReadOnly();

            }
            catch (FileNotFoundException)
            {
                DialogResult result = MessageBox.Show("Sorry, the Special Pizzas were not found", "Missing File", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                switch (result)
                {
                    case DialogResult.Retry:
                        return LoadSpecials();
                        
                    case DialogResult.Cancel:
                        return new List<Pizza>();
                        
                    default:
                        return new List<Pizza>();
                }

            }

        }

        public void SpecialityPizzaSize_CheckChanged(object sender, MouseEventArgs e)
        {
            switch (((RadioButton)sender).Text) {
                case "Small":
                    CurrentSpecialPizza.Crust = "Small";
                    SpecialityPictureBox.Image = resizeImage(SpecialityPictureBox.Image, new Size(140, 140));
                    //SpecialityPictureBox.Image = Image.FromFile("\\Images\\Small.jpg");
                    break;
                case "Medium":
                    CurrentSpecialPizza.Crust = "Medium";
                    SpecialityPictureBox.Image = resizeImage(SpecialityPictureBox.Image, new Size(160, 160));
                    //SpecialityPictureBox.Image = Image.FromFile("\\Images\\Medium.jpg");
                    break;
                case "Large":
                    CurrentSpecialPizza.Crust = "Large";
                    SpecialityPictureBox.Image = resizeImage(SpecialityPictureBox.Image, new Size(180, 180));
                    //SpecialityPictureBox.Image = Image.FromFile("\\Images\\Large.jpg");
                    break;

            }

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add a " + SpecialityComboBox.SelectedText + " pizza to your order?", "Confirm Pizza Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    myCart.PizzaList.Add(SpecialityComboBox.SelectedText);
                    break;
                case DialogResult.No:
                    SpecialityComboBox.SelectedIndex = 0;
                    break;
            }
        }

        private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedText) {
                case "Pepperoni Supereme":
                    SpecialityPictureBox.Image = Image.FromFile("\\Images\\pepperoniSupereme.jpg");

                    break;
                case "Meat Lover's":
                    SpecialityPictureBox.Image = Image.FromFile("\\Images\\meatLovers.jpg");
                    break;
                case "Veggie Lover's":
                    SpecialityPictureBox.Image = Image.FromFile("\\Images\\veggieLovers.jpg");
                    break;

            }

        }

        public static Image resizeImage(Image i, Size size)
        {
            // construct a bitmap using the image, i, and fix it to a new size, then convert it back to an image
            return (Image)(new Bitmap(i, size));
        }
        //private void SpecialityComboBox_SelectedIndexChanged(object sender, MouseEventArgs e)
        //{

        //}
    }
}

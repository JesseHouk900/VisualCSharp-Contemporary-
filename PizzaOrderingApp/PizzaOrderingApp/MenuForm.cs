// pizza pizzaz: Prompt Pizzas
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
        readonly private IReadOnlyCollection<string> SpecialPizzaPictureNames;
        public Pizza CurrentSpecialPizza;
        public MenuForm()
        {
            InitializeComponent();
            MouseEvents();
            if (myCart == null)
            {
                myCart = new Cart();
                myCart.PizzaList = new List<Pizza>();
            }
            Checkout_Label.Text = "Your current total is: $" + myCart.GetTotal();
            ArrayList pizzaInfo = LoadSpecials();
            if (pizzaInfo != null)
            {
                PizzaSpecials = (IReadOnlyCollection<Pizza>)pizzaInfo[0];
                SpecialPizzaNum = (IReadOnlyDictionary<string, int>)pizzaInfo[1];
                SpecialPizzaPictureNames = (IReadOnlyCollection<string>)pizzaInfo[2];
            }
            CurrentSpecialPizza = new Pizza();
            SpecialityComboBox.Items.Add("None");
            for (int i = 0; i < PizzaSpecials.Count(); i++)
            {
                SpecialityComboBox.Items.Add(PizzaSpecials.ElementAt(i).Name);
            }
        }

        private void MouseEvents()
        {
            //SpecialityComboBox.SelectedIndexChanged += new MouseEventHandler(SpecialityComboBox_SelectedIndexChanged);
            SmallPizza_radioButton.MouseDown += new MouseEventHandler(SpecialityPizzaSize_CheckChanged);
            MediumPizza_radioButton.MouseDown += new MouseEventHandler(SpecialityPizzaSize_CheckChanged);
            LargePizza_radioButton.MouseDown += new MouseEventHandler(SpecialityPizzaSize_CheckChanged);
        }

        static public ArrayList LoadSpecials()
        {
            List<Pizza> specialPizzas = new List<Pizza>();
            Dictionary<string, int> pizzaNums = new Dictionary<string, int>();
            List<string> pizzaPicturePaths = new List<string>();
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
                return new ArrayList(3) { specialPizzas.AsReadOnly(),
                    (IReadOnlyDictionary<string, int>)pizzaNums,
                    pizzaPicturePaths.AsReadOnly() };
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

        public void SpecialityPizzaSize_CheckChanged(object sender, MouseEventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Personal":
                    CurrentSpecialPizza.Crust = "Personal";
                    SpecialityPictureBox.Image = ResizeImage(Image.FromFile(CurrentSpecialPizza.Name + ".jpg"), new Size(120, 120));
                    break;
                case "Small":
                    CurrentSpecialPizza.Crust = "Small";
                    SpecialityPictureBox.Image = ResizeImage(Image.FromFile(CurrentSpecialPizza.Name + ".jpg"), new Size(140, 140));
                    break;
                case "Medium":
                    CurrentSpecialPizza.Crust = "Medium";
                    SpecialityPictureBox.Image = ResizeImage(Image.FromFile(CurrentSpecialPizza.Name + ".jpg"), new Size(160, 160));
                    break;
                case "Large":
                    CurrentSpecialPizza.Crust = "Large";
                    SpecialityPictureBox.Image = ResizeImage(Image.FromFile(CurrentSpecialPizza.Name + ".jpg"), new Size(180, 180));
                    break;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add a " + CurrentSpecialPizza.Name + " pizza to your order?", "Confirm Pizza Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    myCart.PizzaList.Add(new Pizza(CurrentSpecialPizza));
                    Checkout_Label.Text = "Your current total is: $" + myCart.GetTotal();
                    break;
                case DialogResult.No:
                    SpecialityComboBox.SelectedIndex = 0;
                    MediumPizza_radioButton.Checked = true;
                    break;
            }
        }

        private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPizzaIndex = SpecialPizzaNum[(string)((ComboBox)sender).SelectedItem];
            Pizza special = new Pizza(PizzaSpecials.ElementAt(selectedPizzaIndex));
            int numPizzaToppings = special.LeftToppings.Count;
            CurrentSpecialPizza.LeftToppings = new List<string>();
            for (int i = 0; i < numPizzaToppings; i++)
            {
                CurrentSpecialPizza.LeftToppings.Add(special.LeftToppings[i]);
            }
            numPizzaToppings = special.RightToppings.Count;
            CurrentSpecialPizza.RightToppings = new List<string>();
            for (int i = 0; i < numPizzaToppings; i++)
            {
                CurrentSpecialPizza.RightToppings.Add(special.RightToppings[i]);
            }
            SpecialityPictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\" + special.Name);
            // scale maybe?
        }
        // pass in an image and the size
        public static Image ResizeImage(Image i, Size size)
        {
            // construct a bitmap using the image, i, and fix it to a new size, then convert it back to an image
            return (Image)(new Bitmap(i, size));
        }

        private void CreateYourOwnButton_Click(object sender, EventArgs e)
        {
            CustomizePizzaForm form = new CustomizePizzaForm();
            form.Show();
            this.Hide();
        }

        private void Checkout_Button_Click(object sender, EventArgs e)
        {
            CartForm form = new CartForm();
            form.Show();
            this.Hide();
        }
    }
}

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
        public Pizza CurrentSpecialPizza;
        public PictureBox[] CurrentSpecialPizzaPictureBoxes;
        public IReadOnlyDictionary<string, string> Ingredients;
        public MenuForm()
        {
            InitializeComponent();
            MouseEvents();
            myCart = new Cart();
            Ingredients = LoadPizzaIngredients();
            ArrayList pizzaInfo = LoadSpecials();
            if (pizzaInfo != null)
            {
                PizzaSpecials = (IReadOnlyCollection<Pizza>)pizzaInfo[0];
                SpecialPizzaNum = (IReadOnlyDictionary<string, int>)pizzaInfo[1];
                CurrentSpecialPizza = new Pizza();

            }
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
            try
            {
                string line;
                int i = -1;

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
                            specialPizzas[i].toppings.Add(line.Split('-')[1]);
                            break;
                        case '$':
                            specialPizzas[i].Price = decimal.Parse(line.Split('$')[1]);
                            break;
                        default:
                            i++;
                            specialPizzas.Add(new Pizza(line));
                            pizzaNums[line] = i;
                            break;
                    }
                    
                }
                return new ArrayList(2) {specialPizzas.AsReadOnly(), (IReadOnlyDictionary<string, int>)pizzaNums };

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
            switch (((RadioButton)sender).Text) {
                case "Small":
                    CurrentSpecialPizza.Crust = "Small";
                    SpecialityPictureBox.Image = resizeImage(Image.FromFile("BasicPizzaCrust.jpg"), new Size(140, 140));
                    //SpecialityPictureBox.Image = Image.FromFile("\\Images\\Small.jpg");
                    break;
                case "Medium":
                    CurrentSpecialPizza.Crust = "Medium";
                    SpecialityPictureBox.Image = resizeImage(Image.FromFile("BasicPizzaCrust.jpg"), new Size(160, 160));
                    //SpecialityPictureBox.Image = Image.FromFile("\\Images\\Medium.jpg");
                    break;
                case "Large":
                    CurrentSpecialPizza.Crust = "Large";
                    SpecialityPictureBox.Image = resizeImage(Image.FromFile("BasicPizzaCrust.jpg"), new Size(180, 180));
                    //SpecialityPictureBox.Image = Image.FromFile("\\Images\\Large.jpg");
                    break;

            }

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add a " + SpecialityComboBox.SelectedItem + " pizza to your order?", "Confirm Pizza Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    myCart.PizzaList.Add(SpecialityComboBox.SelectedItem);
                    break;
                case DialogResult.No:
                    SpecialityComboBox.SelectedIndex = 0;
                    break;
            }
        }

        private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPizzaIndex = SpecialPizzaNum[(string)((ComboBox)sender).SelectedItem];
            Pizza special = new Pizza(PizzaSpecials.ElementAt(selectedPizzaIndex));
            int numPizzaToppings = special.toppings.Count;
            CurrentSpecialPizzaPictureBoxes = new PictureBox[numPizzaToppings];


            for (int i = 3; i < numPizzaToppings; i++)
            {
                CurrentSpecialPizza.toppings.Add(special.toppings[i]);
            }
            //LoadSpecialityPizza();

            //SpecialityPictureBox.Image = Image.FromFile(Ingredients[(string)CurrentSpecialPizza.toppings[0]]);
            for (int i = 0; i < CurrentSpecialPizza.toppings.Count; i++)
            {
                CurrentSpecialPizzaPictureBoxes[i] = new PictureBox();
                if (i != 0)
                {
                    CurrentSpecialPizzaPictureBoxes[i].Image = resizeImage(Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\" + Ingredients[(string)(CurrentSpecialPizza.toppings[i])]), SpecialityPictureBox.Size);
                    CurrentSpecialPizzaPictureBoxes[i].Load(Directory.GetCurrentDirectory() + "\\Images\\" + Ingredients[(string)(CurrentSpecialPizza.toppings[i])]);
                    CurrentSpecialPizzaPictureBoxes[i - 1].Controls.Add(CurrentSpecialPizzaPictureBoxes[i]);
                }
                else
                {
                    CurrentSpecialPizzaPictureBoxes[i].Image = resizeImage(Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\BasicPizzaCrust.jpg"), SpecialityPictureBox.Size);
                    CurrentSpecialPizzaPictureBoxes[i].Load(Directory.GetCurrentDirectory() + "\\Images\\BasicPizzaCrust.jpg");
                    SpecialityPictureBox.Controls.Add(CurrentSpecialPizzaPictureBoxes[i]);
                }
                CurrentSpecialPizzaPictureBoxes[i].Parent = SpecialityPictureBox;
                CurrentSpecialPizzaPictureBoxes[i].SizeMode = PictureBoxSizeMode.CenterImage;
                CurrentSpecialPizzaPictureBoxes[i].BorderStyle = BorderStyle.FixedSingle;
                CurrentSpecialPizzaPictureBoxes[i].Anchor = AnchorStyles.Left;
                CurrentSpecialPizzaPictureBoxes[i].Size = CurrentSpecialPizzaPictureBoxes[i].Image.Size;
                CurrentSpecialPizzaPictureBoxes[i].Visible = true;
                CurrentSpecialPizzaPictureBoxes[i].BackColor = Color.Transparent;
                CurrentSpecialPizzaPictureBoxes[i].Location = new Point(SpecialityPictureBox.Location.X, SpecialityPictureBox.Location.Y);

            }
            //for (int i = 0; i < numPizzaToppings - 1; i++)
            //{
            //    //CurrentSpecialPizzaPictureBoxes[i].BringToFront();
            //}
            CurrentSpecialPizzaPictureBoxes[numPizzaToppings - 1].BringToFront();
        }

        public static Image resizeImage(Image i, Size size)
        {
            // construct a bitmap using the image, i, and fix it to a new size, then convert it back to an image
            return (Image)(new Bitmap(i, size));
        }

        private IReadOnlyDictionary<string, string> LoadPizzaIngredients()
        {
            Dictionary<string, string> ingreds = new Dictionary<string, string>();
            ingreds["cheese"] = "Cheese.png";
            ingreds["tomato sauce"] = "TomatoSauce.png";
            ingreds["alfredo sauce"] = "AlfredoSauce.png";
            ingreds["double pepperoni"] = "DoublePepperoni.png";
            ingreds["pepperoni"] = "Pepperoni.png";
            ingreds["sausage"] = "Sausage.png";
            ingreds["bacon"] = "Bacon.png";
            ingreds["ham"] = "Ham.png";
            ingreds["red onions"] = "RedOnions.png";
            ingreds["black olives"] = "BlackOlives.png";
            ingreds["mushrooms"] = "Mushrooms.png";
            ingreds["green bell peppers"] = "GreenBellPeppers.png";
            ingreds["tomatoes "] = "Tomatoes.png";
            return (IReadOnlyDictionary<string, string>)ingreds;
        }

        private void LoadSpecialityPizza()
        {
            //SpecialityPictureBox.Image = Image.FromFile(Ingredients[(string)CurrentSpecialPizza.toppings[0]]);
            for (int i = 0; i < CurrentSpecialPizza.toppings.Count; i++)
            {
                CurrentSpecialPizzaPictureBoxes[i] = new PictureBox();
                CurrentSpecialPizzaPictureBoxes[i].Location = new Point(SpecialityPictureBox.Location.X, SpecialityPictureBox.Location.Y);
                if (i != 0)
                {
                    CurrentSpecialPizzaPictureBoxes[i].Image = resizeImage(Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\" + Ingredients[(string)(CurrentSpecialPizza.toppings[i])]), SpecialityPictureBox.Size);
                    CurrentSpecialPizzaPictureBoxes[i].Load(Directory.GetCurrentDirectory() + "\\Images\\" + Ingredients[(string)(CurrentSpecialPizza.toppings[i])]);
                    CurrentSpecialPizzaPictureBoxes[i].Parent = CurrentSpecialPizzaPictureBoxes[i - 1];
                }
                else
                {
                    CurrentSpecialPizzaPictureBoxes[i].Image = resizeImage(Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\BasicPizzaCrust.jpg"), SpecialityPictureBox.Size);
                    CurrentSpecialPizzaPictureBoxes[i].Load(Directory.GetCurrentDirectory() + "\\Images\\BasicPizzaCrust.jpg");
                }
                CurrentSpecialPizzaPictureBoxes[i].SizeMode = PictureBoxSizeMode.CenterImage;
                CurrentSpecialPizzaPictureBoxes[i].BorderStyle = BorderStyle.FixedSingle;
                CurrentSpecialPizzaPictureBoxes[i].Anchor = AnchorStyles.Left;
                CurrentSpecialPizzaPictureBoxes[i].Size = CurrentSpecialPizzaPictureBoxes[i].Image.Size;
                CurrentSpecialPizzaPictureBoxes[i].Visible = true;
                this.Controls.Add(CurrentSpecialPizzaPictureBoxes[i]);
                CurrentSpecialPizzaPictureBoxes[i].BackColor = Color.Transparent;

            }
        }
        //private void SpecialityComboBox_SelectedIndexChanged(object sender, MouseEventArgs e)
        //{

        //}
    }
}

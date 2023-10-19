using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozraha
{
    public partial class GetOrder : Form
    {
        Drink orderedDrink;
        Food orderedFood;
        Form form;

        bool exitButtonClicked = false;

        public GetOrder(MakeOrder form)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 150);

            orderedDrink = form.orderedDrink;
            orderedFood = form.orderedFood;

            firstAddPictureBox.Visible = false;
            secondAddPictureBox.Visible = false;
            thirdAddPictureBox.Visible = false;
            fourthAddPictureBox.Visible = false;
            sugarPictureBox.Visible = false;
            noAddsPictureBox.Visible = false;

            List<string> list = orderedDrink.GetInfo();

            if (list.Count > 0)
            {
                if (list[0] == "Sugar")
                {
                    sugarPictureBox.Visible = true;
                }
            }
            else
            {
                noAddsPictureBox.Visible = true;
            }

            if (orderedDrink.Type == "Coffee")
            {
                switch (orderedDrink.SubType)
                {
                    case "Лате":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.late;
                        break;
                    case "Раф":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.raf;
                        break;
                    case "Американо":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.americano;
                        break;
                    case "Капучіно":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.capuccino;
                        break;
                    default:
                        break;
                }

                firstAddPictureBox.Image = Properties.Resources.cinnamon;
                secondAddPictureBox.Image = Properties.Resources.chocolate;
                thirdAddPictureBox.Image = Properties.Resources.marshmellou;
                fourthAddPictureBox.Image = Properties.Resources.vanilin;

                foreach(var item in list)
                {
                    switch (item) 
                    {
                        case "Cinnamon":
                            firstAddPictureBox.Visible=true;
                            break;
                        case "Chocolate":
                            secondAddPictureBox.Visible = true;
                            break;
                        case "Marshshmallows":
                            thirdAddPictureBox.Visible = true;
                            break;
                        case "Vanilla":
                            fourthAddPictureBox.Visible = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            else {
                switch (orderedDrink.SubType)
                {
                    case "Чорний":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.black;
                        break;
                    case "Зелений":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.green;
                        break;
                    case "Улун":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.ulun;
                        break;
                    case "Фруктовий":
                        drinkPictureBox.Image = Rozraha.Properties.Resources.fruit;
                        break;
                    default:
                        break;
                }

                firstAddPictureBox.Image = Properties.Resources.mint;
                secondAddPictureBox.Image = Properties.Resources.lemon;
                thirdAddPictureBox.Image = Properties.Resources.orange;
                fourthAddPictureBox.Image = Properties.Resources.milk;

                foreach (var item in list)
                {
                    switch (item)
                    {
                        case "Mint":
                            firstAddPictureBox.Visible = true;
                            break;
                        case "Lemon":
                            secondAddPictureBox.Visible = true;
                            break;
                        case "Orange":
                            thirdAddPictureBox.Visible = true;
                            break;
                        case "Milk":
                            fourthAddPictureBox.Visible = true;
                            break;
                        default:
                            break;
                    }
                }
            }

            int price = orderedDrink.Price;

            smallFoodPictureBox.Visible = false;
            mediumFoodPictureBox.Visible = false;
            bigFoodPictureBox.Visible = false;

            noFoodPictureBox.Visible = true;

            if (orderedFood != null)
            {
                price+=orderedFood.Price;

                noFoodPictureBox.Visible = false;

                switch (orderedFood.Type)
                {
                    case 0:
                        smallFoodPictureBox.Image = Properties.Resources.burger;
                        mediumFoodPictureBox.Image = Properties.Resources.burger;
                        bigFoodPictureBox.Image = Properties.Resources.burger;
                        break;
                    case 1:
                        smallFoodPictureBox.Image = Properties.Resources.pizza;
                        mediumFoodPictureBox.Image = Properties.Resources.pizza;
                        bigFoodPictureBox.Image = Properties.Resources.pizza;
                        break;
                    case 2:
                        smallFoodPictureBox.Image = Properties.Resources.roll;
                        mediumFoodPictureBox.Image = Properties.Resources.roll;
                        bigFoodPictureBox.Image = Properties.Resources.roll;
                        break;
                    case 3:
                        smallFoodPictureBox.Image = Properties.Resources.free;
                        mediumFoodPictureBox.Image = Properties.Resources.free;
                        bigFoodPictureBox.Image = Properties.Resources.free;
                        break;
                    default:
                        break;
                }

                switch (orderedFood.Size)
                {
                    case 1:
                        smallFoodPictureBox.Visible = true;
                        break;
                    case 2:
                        mediumFoodPictureBox.Visible = true;
                        break;
                    case 3:
                        bigFoodPictureBox.Visible = true;
                        break;
                    default:
                        break;
                }
            }

            fullPriceLabel.Text += " " + price.ToString() + " грн.";

            form.Visible = false;
            this.form = form;
        }

        private void orderMoreButton_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            exitButtonClicked = true;
            this.Close();
        }

        private void goodByeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if(!exitButtonClicked)
                {
                    Application.Exit();
                }             
            }
        }

    }
}

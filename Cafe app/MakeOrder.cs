using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rozraha
{
    public partial class MakeOrder : Form
    {
        public Drink orderedDrink;
        public Food orderedFood;

        public MakeOrder()
        {
            InitializeComponent();

            this.CoffeeBox.Text = "Лате";
            this.TeaBox.Text = "Чорний";
            this.foodBox.Text = "Бургер";

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //services.AddTransient<ICounter, SaleCounter>();
            services.AddTransient<ICounter, SimpleCounter>();
            services.AddTransient<MakeOrder>();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.CoffeeBox.Visible = true;
            this.TeaBox.Visible = false;
            this.coffeeListBox.Visible = true;
            this.teaListBox.Visible = false;
            this.coffeeSugarBox.Visible = true;
            this.teaSugarBox.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.CoffeeBox.Visible = false;
            this.TeaBox.Visible = true;
            this.coffeeListBox.Visible = false;
            this.teaListBox.Visible = true;
            this.coffeeSugarBox.Visible = false;
            this.teaSugarBox.Visible = true;
        }

        private void withFoodButton_CheckedChanged(object sender, EventArgs e)
        {
            this.foodSizeGroupBox.Visible = true;
            this.foodTypeGroupBox.Visible = true;
        }

        private void withoutFoodButton_CheckedChanged(object sender, EventArgs e)
        {
            this.foodSizeGroupBox.Visible = false;
            this.foodTypeGroupBox.Visible = false;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            IBuilder builder;
            
            bool isSugar;
            string type;
            string subType;
            Dictionary<string, bool> addons = new Dictionary<string, bool>();
            bool[] isChecked = new bool[4];

            if (teaButton.Checked)
            {
                builder = new TeaBuilder();
                isSugar = teaWithSugarButton.Checked;
                subType = TeaBox.Text;
                type = "Tea";
            }
            else
            {
                builder = new CoffeeBuilder();
                isSugar = coffeeWithSugarButton.Checked;
                subType = CoffeeBox.Text;
                type = "Coffee";
            }

            CheckedListBox listBox = teaButton.Checked ? teaListBox : coffeeListBox;
            foreach (int item in listBox.CheckedIndices)
            {
                isChecked[item] = true;
            }

            addons["First"] = isChecked[0];
            addons["Second"] = isChecked[1];
            addons["Third"] = isChecked[2];
            addons["Fourth"] = isChecked[3];

            director.Make(builder: builder, adds: addons, isSugar: isSugar, type: type, subType: subType);

            orderedDrink = builder.GetResult();

            orderedDrink.CalcPrice();

            if (withFoodButton.Checked)
            {
                int foodType = 0;

                foodType = foodBox.SelectedIndex;

                int foodSize = 0;

                if (smallButton.Checked)
                {
                    foodSize = 1;
                }
                else if (mediumButton.Checked)
                {
                    foodSize = 2;
                }
                else
                {
                    foodSize = 3;
                }

                var services = new ServiceCollection();

                ConfigureServices(services);

                using (ServiceProvider serviceProvider = services.BuildServiceProvider())
                {
                    var counter = serviceProvider.GetRequiredService<ICounter>();
                    orderedFood = new Food(counter: counter, type: foodType, size: foodSize);
                    orderedFood.FindPrice();
                }
            }
            else
            {
                orderedFood = null;
            }

            GetOrder form = new GetOrder(this);
            form.Show();
        }
    }
}

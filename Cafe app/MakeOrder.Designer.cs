using System.Windows.Forms;

namespace Rozraha
{
    partial class MakeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrder));
            this.drinkLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.coffeeButton = new System.Windows.Forms.RadioButton();
            this.teaButton = new System.Windows.Forms.RadioButton();
            this.drinkTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.drinkTypeLabel = new System.Windows.Forms.Label();
            this.TeaBox = new System.Windows.Forms.ComboBox();
            this.CoffeeBox = new System.Windows.Forms.ComboBox();
            this.teaSugarBox = new System.Windows.Forms.GroupBox();
            this.teaWithSugarButton = new System.Windows.Forms.RadioButton();
            this.teaWithoutSugarButton = new System.Windows.Forms.RadioButton();
            this.teaSugarLabel = new System.Windows.Forms.Label();
            this.coffeeSugarBox = new System.Windows.Forms.GroupBox();
            this.coffeeWithSugarButton = new System.Windows.Forms.RadioButton();
            this.coffeeWithoutSugarButton = new System.Windows.Forms.RadioButton();
            this.coffeeSugarLabel = new System.Windows.Forms.Label();
            this.additionsLabel = new System.Windows.Forms.Label();
            this.coffeeListBox = new System.Windows.Forms.CheckedListBox();
            this.teaListBox = new System.Windows.Forms.CheckedListBox();
            this.foodLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.withFoodButton = new System.Windows.Forms.RadioButton();
            this.withoutFoodButton = new System.Windows.Forms.RadioButton();
            this.foodLabel = new System.Windows.Forms.Label();
            this.foodTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.foodTypeLabel = new System.Windows.Forms.Label();
            this.foodBox = new System.Windows.Forms.ComboBox();
            this.foodSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.bigButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.foodSizeLabel = new System.Windows.Forms.Label();
            this.foodPicture = new System.Windows.Forms.PictureBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.formOrderLabel = new System.Windows.Forms.Label();
            this.drinkLayoutPanel.SuspendLayout();
            this.drinkTypeGroupBox.SuspendLayout();
            this.teaSugarBox.SuspendLayout();
            this.coffeeSugarBox.SuspendLayout();
            this.foodLayoutPanel.SuspendLayout();
            this.foodGroupBox.SuspendLayout();
            this.foodTypeGroupBox.SuspendLayout();
            this.foodSizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // drinkLayoutPanel
            // 
            this.drinkLayoutPanel.Controls.Add(this.drinkLabel);
            this.drinkLayoutPanel.Controls.Add(this.coffeeButton);
            this.drinkLayoutPanel.Controls.Add(this.teaButton);
            this.drinkLayoutPanel.Controls.Add(this.drinkTypeGroupBox);
            this.drinkLayoutPanel.Controls.Add(this.teaSugarBox);
            this.drinkLayoutPanel.Controls.Add(this.coffeeSugarBox);
            this.drinkLayoutPanel.Controls.Add(this.additionsLabel);
            this.drinkLayoutPanel.Controls.Add(this.coffeeListBox);
            this.drinkLayoutPanel.Controls.Add(this.teaListBox);
            this.drinkLayoutPanel.Location = new System.Drawing.Point(12, 47);
            this.drinkLayoutPanel.Name = "drinkLayoutPanel";
            this.drinkLayoutPanel.Size = new System.Drawing.Size(494, 396);
            this.drinkLayoutPanel.TabIndex = 0;
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkLabel.Location = new System.Drawing.Point(3, 0);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Padding = new System.Windows.Forms.Padding(0, 0, 250, 0);
            this.drinkLabel.Size = new System.Drawing.Size(332, 29);
            this.drinkLabel.TabIndex = 4;
            this.drinkLabel.Text = "Напій:";
            // 
            // coffeeButton
            // 
            this.coffeeButton.AutoSize = true;
            this.coffeeButton.Image = global::Rozraha.Properties.Resources.coffee1;
            this.coffeeButton.Location = new System.Drawing.Point(3, 32);
            this.coffeeButton.Name = "coffeeButton";
            this.coffeeButton.Size = new System.Drawing.Size(167, 89);
            this.coffeeButton.TabIndex = 0;
            this.coffeeButton.TabStop = true;
            this.coffeeButton.UseVisualStyleBackColor = true;
            this.coffeeButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // teaButton
            // 
            this.teaButton.AutoSize = true;
            this.teaButton.Image = global::Rozraha.Properties.Resources.tea;
            this.teaButton.Location = new System.Drawing.Point(176, 32);
            this.teaButton.Name = "teaButton";
            this.teaButton.Size = new System.Drawing.Size(167, 84);
            this.teaButton.TabIndex = 1;
            this.teaButton.TabStop = true;
            this.teaButton.UseVisualStyleBackColor = true;
            this.teaButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // drinkTypeGroupBox
            // 
            this.drinkTypeGroupBox.Controls.Add(this.drinkTypeLabel);
            this.drinkTypeGroupBox.Controls.Add(this.TeaBox);
            this.drinkTypeGroupBox.Controls.Add(this.CoffeeBox);
            this.drinkTypeGroupBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkTypeGroupBox.Location = new System.Drawing.Point(3, 127);
            this.drinkTypeGroupBox.Name = "drinkTypeGroupBox";
            this.drinkTypeGroupBox.Size = new System.Drawing.Size(213, 54);
            this.drinkTypeGroupBox.TabIndex = 5;
            this.drinkTypeGroupBox.TabStop = false;
            // 
            // drinkTypeLabel
            // 
            this.drinkTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drinkTypeLabel.AutoSize = true;
            this.drinkTypeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkTypeLabel.Location = new System.Drawing.Point(7, 15);
            this.drinkTypeLabel.Name = "drinkTypeLabel";
            this.drinkTypeLabel.Size = new System.Drawing.Size(55, 26);
            this.drinkTypeLabel.TabIndex = 2;
            this.drinkTypeLabel.Text = "Тип:";
            this.drinkTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeaBox
            // 
            this.TeaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeaBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeaBox.FormattingEnabled = true;
            this.TeaBox.Items.AddRange(new object[] {
            "Чорний",
            "Зелений",
            "Улун",
            "Фруктовий"});
            this.TeaBox.Location = new System.Drawing.Point(68, 15);
            this.TeaBox.Name = "TeaBox";
            this.TeaBox.Size = new System.Drawing.Size(139, 28);
            this.TeaBox.TabIndex = 4;
            // 
            // CoffeeBox
            // 
            this.CoffeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoffeeBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoffeeBox.FormattingEnabled = true;
            this.CoffeeBox.Items.AddRange(new object[] {
            "Лате",
            "Раф",
            "Американо",
            "Капучіно"});
            this.CoffeeBox.Location = new System.Drawing.Point(68, 15);
            this.CoffeeBox.Name = "CoffeeBox";
            this.CoffeeBox.Size = new System.Drawing.Size(139, 28);
            this.CoffeeBox.TabIndex = 3;
            // 
            // teaSugarBox
            // 
            this.teaSugarBox.Controls.Add(this.teaWithSugarButton);
            this.teaSugarBox.Controls.Add(this.teaWithoutSugarButton);
            this.teaSugarBox.Controls.Add(this.teaSugarLabel);
            this.teaSugarBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teaSugarBox.Location = new System.Drawing.Point(222, 127);
            this.teaSugarBox.Name = "teaSugarBox";
            this.teaSugarBox.Size = new System.Drawing.Size(223, 54);
            this.teaSugarBox.TabIndex = 7;
            this.teaSugarBox.TabStop = false;
            // 
            // teaWithSugarButton
            // 
            this.teaWithSugarButton.AutoSize = true;
            this.teaWithSugarButton.Checked = true;
            this.teaWithSugarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teaWithSugarButton.Location = new System.Drawing.Point(90, 18);
            this.teaWithSugarButton.Name = "teaWithSugarButton";
            this.teaWithSugarButton.Size = new System.Drawing.Size(39, 26);
            this.teaWithSugarButton.TabIndex = 3;
            this.teaWithSugarButton.TabStop = true;
            this.teaWithSugarButton.Text = "з";
            this.teaWithSugarButton.UseVisualStyleBackColor = true;
            // 
            // teaWithoutSugarButton
            // 
            this.teaWithoutSugarButton.AutoSize = true;
            this.teaWithoutSugarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teaWithoutSugarButton.Location = new System.Drawing.Point(149, 18);
            this.teaWithoutSugarButton.Name = "teaWithoutSugarButton";
            this.teaWithoutSugarButton.Size = new System.Drawing.Size(58, 26);
            this.teaWithoutSugarButton.TabIndex = 4;
            this.teaWithoutSugarButton.Text = "без";
            this.teaWithoutSugarButton.UseVisualStyleBackColor = true;
            // 
            // teaSugarLabel
            // 
            this.teaSugarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teaSugarLabel.AutoSize = true;
            this.teaSugarLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teaSugarLabel.Location = new System.Drawing.Point(7, 18);
            this.teaSugarLabel.Name = "teaSugarLabel";
            this.teaSugarLabel.Size = new System.Drawing.Size(78, 26);
            this.teaSugarLabel.TabIndex = 2;
            this.teaSugarLabel.Text = "Цукор:";
            this.teaSugarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coffeeSugarBox
            // 
            this.coffeeSugarBox.Controls.Add(this.coffeeWithSugarButton);
            this.coffeeSugarBox.Controls.Add(this.coffeeWithoutSugarButton);
            this.coffeeSugarBox.Controls.Add(this.coffeeSugarLabel);
            this.coffeeSugarBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffeeSugarBox.Location = new System.Drawing.Point(3, 187);
            this.coffeeSugarBox.Name = "coffeeSugarBox";
            this.coffeeSugarBox.Size = new System.Drawing.Size(223, 54);
            this.coffeeSugarBox.TabIndex = 6;
            this.coffeeSugarBox.TabStop = false;
            // 
            // coffeeWithSugarButton
            // 
            this.coffeeWithSugarButton.AutoSize = true;
            this.coffeeWithSugarButton.Checked = true;
            this.coffeeWithSugarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffeeWithSugarButton.Location = new System.Drawing.Point(90, 18);
            this.coffeeWithSugarButton.Name = "coffeeWithSugarButton";
            this.coffeeWithSugarButton.Size = new System.Drawing.Size(39, 26);
            this.coffeeWithSugarButton.TabIndex = 3;
            this.coffeeWithSugarButton.TabStop = true;
            this.coffeeWithSugarButton.Text = "з";
            this.coffeeWithSugarButton.UseVisualStyleBackColor = true;
            // 
            // coffeeWithoutSugarButton
            // 
            this.coffeeWithoutSugarButton.AutoSize = true;
            this.coffeeWithoutSugarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffeeWithoutSugarButton.Location = new System.Drawing.Point(149, 18);
            this.coffeeWithoutSugarButton.Name = "coffeeWithoutSugarButton";
            this.coffeeWithoutSugarButton.Size = new System.Drawing.Size(58, 26);
            this.coffeeWithoutSugarButton.TabIndex = 4;
            this.coffeeWithoutSugarButton.Text = "без";
            this.coffeeWithoutSugarButton.UseVisualStyleBackColor = true;
            // 
            // coffeeSugarLabel
            // 
            this.coffeeSugarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coffeeSugarLabel.AutoSize = true;
            this.coffeeSugarLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffeeSugarLabel.Location = new System.Drawing.Point(7, 18);
            this.coffeeSugarLabel.Name = "coffeeSugarLabel";
            this.coffeeSugarLabel.Size = new System.Drawing.Size(78, 26);
            this.coffeeSugarLabel.TabIndex = 2;
            this.coffeeSugarLabel.Text = "Цукор:";
            this.coffeeSugarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionsLabel
            // 
            this.additionsLabel.AutoSize = true;
            this.additionsLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionsLabel.Location = new System.Drawing.Point(232, 184);
            this.additionsLabel.Name = "additionsLabel";
            this.additionsLabel.Size = new System.Drawing.Size(102, 26);
            this.additionsLabel.TabIndex = 8;
            this.additionsLabel.Text = "Доданки:";
            // 
            // coffeeListBox
            // 
            this.coffeeListBox.BackColor = System.Drawing.SystemColors.Window;
            this.coffeeListBox.CheckOnClick = true;
            this.coffeeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffeeListBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.coffeeListBox.FormattingEnabled = true;
            this.coffeeListBox.Items.AddRange(new object[] {
            "Кориця",
            "Шоколад",
            "Маршмелоу",
            "Ваніль"});
            this.coffeeListBox.Location = new System.Drawing.Point(3, 247);
            this.coffeeListBox.MultiColumn = true;
            this.coffeeListBox.Name = "coffeeListBox";
            this.coffeeListBox.Size = new System.Drawing.Size(442, 73);
            this.coffeeListBox.TabIndex = 7;
            // 
            // teaListBox
            // 
            this.teaListBox.BackColor = System.Drawing.SystemColors.Window;
            this.teaListBox.CheckOnClick = true;
            this.teaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teaListBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.teaListBox.FormattingEnabled = true;
            this.teaListBox.Items.AddRange(new object[] {
            "М\'ята",
            "Лимон",
            "Апельсин",
            "Молоко"});
            this.teaListBox.Location = new System.Drawing.Point(3, 326);
            this.teaListBox.MultiColumn = true;
            this.teaListBox.Name = "teaListBox";
            this.teaListBox.Size = new System.Drawing.Size(442, 73);
            this.teaListBox.TabIndex = 9;
            // 
            // foodLayoutPanel
            // 
            this.foodLayoutPanel.Controls.Add(this.foodGroupBox);
            this.foodLayoutPanel.Controls.Add(this.foodTypeGroupBox);
            this.foodLayoutPanel.Controls.Add(this.foodSizeGroupBox);
            this.foodLayoutPanel.Controls.Add(this.foodPicture);
            this.foodLayoutPanel.Location = new System.Drawing.Point(512, 47);
            this.foodLayoutPanel.Name = "foodLayoutPanel";
            this.foodLayoutPanel.Size = new System.Drawing.Size(485, 396);
            this.foodLayoutPanel.TabIndex = 1;
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Controls.Add(this.withFoodButton);
            this.foodGroupBox.Controls.Add(this.withoutFoodButton);
            this.foodGroupBox.Controls.Add(this.foodLabel);
            this.foodGroupBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodGroupBox.Location = new System.Drawing.Point(3, 3);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(270, 54);
            this.foodGroupBox.TabIndex = 9;
            this.foodGroupBox.TabStop = false;
            // 
            // withFoodButton
            // 
            this.withFoodButton.AutoSize = true;
            this.withFoodButton.Checked = true;
            this.withFoodButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withFoodButton.Location = new System.Drawing.Point(82, 17);
            this.withFoodButton.Name = "withFoodButton";
            this.withFoodButton.Size = new System.Drawing.Size(42, 29);
            this.withFoodButton.TabIndex = 3;
            this.withFoodButton.TabStop = true;
            this.withFoodButton.Text = "з";
            this.withFoodButton.UseVisualStyleBackColor = true;
            this.withFoodButton.CheckedChanged += new System.EventHandler(this.withFoodButton_CheckedChanged);
            // 
            // withoutFoodButton
            // 
            this.withoutFoodButton.AutoSize = true;
            this.withoutFoodButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withoutFoodButton.Location = new System.Drawing.Point(149, 17);
            this.withoutFoodButton.Name = "withoutFoodButton";
            this.withoutFoodButton.Size = new System.Drawing.Size(63, 29);
            this.withoutFoodButton.TabIndex = 4;
            this.withoutFoodButton.Text = "без";
            this.withoutFoodButton.UseVisualStyleBackColor = true;
            this.withoutFoodButton.CheckedChanged += new System.EventHandler(this.withoutFoodButton_CheckedChanged);
            // 
            // foodLabel
            // 
            this.foodLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodLabel.Location = new System.Drawing.Point(7, 17);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(60, 29);
            this.foodLabel.TabIndex = 2;
            this.foodLabel.Text = "Їжа:";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodTypeGroupBox
            // 
            this.foodTypeGroupBox.Controls.Add(this.foodTypeLabel);
            this.foodTypeGroupBox.Controls.Add(this.foodBox);
            this.foodTypeGroupBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodTypeGroupBox.Location = new System.Drawing.Point(3, 63);
            this.foodTypeGroupBox.Name = "foodTypeGroupBox";
            this.foodTypeGroupBox.Size = new System.Drawing.Size(213, 54);
            this.foodTypeGroupBox.TabIndex = 6;
            this.foodTypeGroupBox.TabStop = false;
            // 
            // foodTypeLabel
            // 
            this.foodTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodTypeLabel.AutoSize = true;
            this.foodTypeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodTypeLabel.Location = new System.Drawing.Point(7, 15);
            this.foodTypeLabel.Name = "foodTypeLabel";
            this.foodTypeLabel.Size = new System.Drawing.Size(55, 26);
            this.foodTypeLabel.TabIndex = 2;
            this.foodTypeLabel.Text = "Тип:";
            this.foodTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodBox
            // 
            this.foodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodBox.FormattingEnabled = true;
            this.foodBox.Items.AddRange(new object[] {
            "Бургер",
            "Піца",
            "Рол",
            "Картопля фрі"});
            this.foodBox.Location = new System.Drawing.Point(68, 15);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(139, 28);
            this.foodBox.TabIndex = 4;
            // 
            // foodSizeGroupBox
            // 
            this.foodSizeGroupBox.Controls.Add(this.bigButton);
            this.foodSizeGroupBox.Controls.Add(this.mediumButton);
            this.foodSizeGroupBox.Controls.Add(this.smallButton);
            this.foodSizeGroupBox.Controls.Add(this.foodSizeLabel);
            this.foodSizeGroupBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodSizeGroupBox.Location = new System.Drawing.Point(3, 123);
            this.foodSizeGroupBox.Name = "foodSizeGroupBox";
            this.foodSizeGroupBox.Size = new System.Drawing.Size(475, 54);
            this.foodSizeGroupBox.TabIndex = 7;
            this.foodSizeGroupBox.TabStop = false;
            // 
            // bigButton
            // 
            this.bigButton.AutoSize = true;
            this.bigButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigButton.Location = new System.Drawing.Point(331, 17);
            this.bigButton.Name = "bigButton";
            this.bigButton.Size = new System.Drawing.Size(102, 26);
            this.bigButton.TabIndex = 5;
            this.bigButton.Text = "великий";
            this.bigButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mediumButton.Location = new System.Drawing.Point(201, 17);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(106, 26);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "середній";
            this.mediumButton.UseVisualStyleBackColor = true;
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Checked = true;
            this.smallButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallButton.Location = new System.Drawing.Point(99, 16);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(85, 26);
            this.smallButton.TabIndex = 3;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "малий";
            this.smallButton.UseVisualStyleBackColor = true;
            // 
            // foodSizeLabel
            // 
            this.foodSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodSizeLabel.AutoSize = true;
            this.foodSizeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodSizeLabel.Location = new System.Drawing.Point(6, 16);
            this.foodSizeLabel.Name = "foodSizeLabel";
            this.foodSizeLabel.Size = new System.Drawing.Size(84, 26);
            this.foodSizeLabel.TabIndex = 2;
            this.foodSizeLabel.Text = "Розмір:";
            this.foodSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodPicture
            // 
            this.foodPicture.Image = global::Rozraha.Properties.Resources.food;
            this.foodPicture.Location = new System.Drawing.Point(3, 183);
            this.foodPicture.Name = "foodPicture";
            this.foodPicture.Size = new System.Drawing.Size(475, 235);
            this.foodPicture.TabIndex = 8;
            this.foodPicture.TabStop = false;
            // 
            // orderButton
            // 
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.Location = new System.Drawing.Point(387, 451);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(221, 44);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Замовити\r\n";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // formOrderLabel
            // 
            this.formOrderLabel.AutoSize = true;
            this.formOrderLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.formOrderLabel.Location = new System.Drawing.Point(328, 9);
            this.formOrderLabel.Name = "formOrderLabel";
            this.formOrderLabel.Size = new System.Drawing.Size(360, 33);
            this.formOrderLabel.TabIndex = 3;
            this.formOrderLabel.Text = "Сформуйте своє замовлення:\r\n";
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 506);
            this.Controls.Add(this.formOrderLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.foodLayoutPanel);
            this.Controls.Add(this.drinkLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeOrder";
            this.Text = "Кав\'ярня OnMore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.drinkLayoutPanel.ResumeLayout(false);
            this.drinkLayoutPanel.PerformLayout();
            this.drinkTypeGroupBox.ResumeLayout(false);
            this.drinkTypeGroupBox.PerformLayout();
            this.teaSugarBox.ResumeLayout(false);
            this.teaSugarBox.PerformLayout();
            this.coffeeSugarBox.ResumeLayout(false);
            this.coffeeSugarBox.PerformLayout();
            this.foodLayoutPanel.ResumeLayout(false);
            this.foodGroupBox.ResumeLayout(false);
            this.foodGroupBox.PerformLayout();
            this.foodTypeGroupBox.ResumeLayout(false);
            this.foodTypeGroupBox.PerformLayout();
            this.foodSizeGroupBox.ResumeLayout(false);
            this.foodSizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel drinkLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel foodLayoutPanel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label formOrderLabel;
        private System.Windows.Forms.RadioButton coffeeButton;
        private System.Windows.Forms.RadioButton teaButton;
        private System.Windows.Forms.Label drinkTypeLabel;
        private System.Windows.Forms.GroupBox drinkTypeGroupBox;
        private System.Windows.Forms.ComboBox CoffeeBox;
        private System.Windows.Forms.ComboBox TeaBox;
        private Label additionsLabel;
        private CheckedListBox coffeeListBox;
        private CheckedListBox teaListBox;
        private GroupBox teaSugarBox;
        private RadioButton teaWithSugarButton;
        private RadioButton teaWithoutSugarButton;
        private Label teaSugarLabel;
        private GroupBox foodTypeGroupBox;
        private Label foodTypeLabel;
        private ComboBox foodBox;
        private GroupBox foodSizeGroupBox;
        private RadioButton bigButton;
        private RadioButton mediumButton;
        private RadioButton smallButton;
        private Label foodSizeLabel;
        private PictureBox foodPicture;
        private Label drinkLabel;
        private GroupBox foodGroupBox;
        private RadioButton withFoodButton;
        private RadioButton withoutFoodButton;
        private Label foodLabel;
        private GroupBox coffeeSugarBox;
        private RadioButton coffeeWithSugarButton;
        private RadioButton coffeeWithoutSugarButton;
        private Label coffeeSugarLabel;
    }
}


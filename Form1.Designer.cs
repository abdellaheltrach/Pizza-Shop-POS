namespace Pizza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSamll = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSamll);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(54, 128);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSize.Size = new System.Drawing.Size(248, 187);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.Transparent;
            this.rbLarge.CausesValidation = false;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(40, 131);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(72, 29);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Larg";
            this.rbLarge.UseVisualStyleBackColor = false;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.Transparent;
            this.rbMedium.CausesValidation = false;
            this.rbMedium.Checked = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(40, 85);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(103, 29);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Meduim";
            this.rbMedium.UseVisualStyleBackColor = false;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSamll
            // 
            this.rbSamll.AutoSize = true;
            this.rbSamll.BackColor = System.Drawing.Color.Transparent;
            this.rbSamll.CausesValidation = false;
            this.rbSamll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSamll.Location = new System.Drawing.Point(40, 39);
            this.rbSamll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSamll.Name = "rbSamll";
            this.rbSamll.Size = new System.Drawing.Size(82, 29);
            this.rbSamll.TabIndex = 0;
            this.rbSamll.Tag = "20";
            this.rbSamll.Text = "Small";
            this.rbSamll.UseVisualStyleBackColor = false;
            this.rbSamll.CheckedChanged += new System.EventHandler(this.rbSamll_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(345, 128);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbToppings.Size = new System.Drawing.Size(335, 187);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.BackColor = System.Drawing.Color.Transparent;
            this.chkGreenPeppers.CausesValidation = false;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(166, 111);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(166, 29);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkGreenPeppers.UseVisualStyleBackColor = false;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chckGreenPeppers_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.BackColor = System.Drawing.Color.Transparent;
            this.chkTomatos.CausesValidation = false;
            this.chkTomatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatos.Location = new System.Drawing.Point(8, 111);
            this.chkTomatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(122, 29);
            this.chkTomatos.TabIndex = 4;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatoes";
            this.chkTomatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkTomatos.UseVisualStyleBackColor = false;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.BackColor = System.Drawing.Color.Transparent;
            this.chkOlives.CausesValidation = false;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(166, 73);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(89, 29);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkOlives.UseVisualStyleBackColor = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.BackColor = System.Drawing.Color.Transparent;
            this.chkMushrooms.CausesValidation = false;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(8, 73);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(137, 29);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMushrooms.UseVisualStyleBackColor = false;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.Transparent;
            this.chkOnion.CausesValidation = false;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(166, 39);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(87, 29);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.BackColor = System.Drawing.Color.Transparent;
            this.chkExtraChees.CausesValidation = false;
            this.chkExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.Location = new System.Drawing.Point(8, 39);
            this.chkExtraChees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(142, 29);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = false;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.Color.White;
            this.gbCrustType.Location = new System.Drawing.Point(54, 334);
            this.gbCrustType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCrustType.Size = new System.Drawing.Size(248, 126);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.BackColor = System.Drawing.Color.Transparent;
            this.rbThickCrust.CausesValidation = false;
            this.rbThickCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(17, 83);
            this.rbThickCrust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(134, 29);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Think Crust";
            this.rbThickCrust.UseVisualStyleBackColor = false;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.BackColor = System.Drawing.Color.Transparent;
            this.rbThinCrust.CausesValidation = false;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(17, 37);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(124, 29);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = false;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.gbWhereToEat.Location = new System.Drawing.Point(345, 334);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbWhereToEat.Size = new System.Drawing.Size(335, 85);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.BackColor = System.Drawing.Color.Transparent;
            this.rbTakeOut.CausesValidation = false;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(119, 37);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(115, 29);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = false;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.BackColor = System.Drawing.Color.Transparent;
            this.rbEatIn.CausesValidation = false;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(17, 37);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(83, 29);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = false;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPizza.Location = new System.Drawing.Point(345, 437);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(119, 40);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Transparent;
            this.btnResetForm.ForeColor = System.Drawing.Color.Black;
            this.btnResetForm.Location = new System.Drawing.Point(561, 437);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(119, 40);
            this.btnResetForm.TabIndex = 5;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblTotalPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblWhereToEat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCrustType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblToppings);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(703, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(335, 349);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(116, 256);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(129, 91);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Price: ";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereToEat.CausesValidation = false;
            this.lblWhereToEat.Location = new System.Drawing.Point(125, 209);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(62, 25);
            this.lblWhereToEat.TabIndex = 8;
            this.lblWhereToEat.Text = "Eat In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Where to Eat: ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrustType.CausesValidation = false;
            this.lblCrustType.Location = new System.Drawing.Point(125, 155);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(103, 25);
            this.lblCrustType.TabIndex = 6;
            this.lblCrustType.Text = "Thin Crust";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Crust Type:";
            // 
            // lblToppings
            // 
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.CausesValidation = false;
            this.lblToppings.Location = new System.Drawing.Point(63, 102);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(265, 53);
            this.lblToppings.TabIndex = 4;
            this.lblToppings.Text = "No Toppings.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.CausesValidation = false;
            this.lblSize.Location = new System.Drawing.Point(63, 38);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(82, 25);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Meduim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Simple Indust Outline", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(52, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 109);
            this.label2.TabIndex = 7;
            this.label2.Text = "Make Your Pizza";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(345, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(335, 349);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Order is : ";
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(116, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 91);
            this.label3.TabIndex = 10;
            this.label3.Text = "$0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Price: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.CausesValidation = false;
            this.label9.Location = new System.Drawing.Point(125, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Eat In";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Where to Eat: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.CausesValidation = false;
            this.label11.Location = new System.Drawing.Point(125, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Thin Crust";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Crust Type:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.CausesValidation = false;
            this.label13.Location = new System.Drawing.Point(63, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(265, 53);
            this.label13.TabIndex = 4;
            this.label13.Text = "No Toppings.";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.CausesValidation = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Toppings:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.CausesValidation = false;
            this.label15.Location = new System.Drawing.Point(63, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Meduim";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Size: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza.Properties.Resources.shutterstock_594962792;
            this.ClientSize = new System.Drawing.Size(1075, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSamll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}


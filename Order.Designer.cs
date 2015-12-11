namespace Pizza
{
    partial class Order
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
            this.label2 = new System.Windows.Forms.Label();
            this.SelToppings = new System.Windows.Forms.Label();
            this.SelSize = new System.Windows.Forms.Label();
            this.SelPizza = new System.Windows.Forms.Label();
            this.Toppings = new System.Windows.Forms.ComboBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Phn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pizza = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.AddressTxt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // SelToppings
            // 
            this.SelToppings.AutoSize = true;
            this.SelToppings.Location = new System.Drawing.Point(3, 98);
            this.SelToppings.Name = "SelToppings";
            this.SelToppings.Size = new System.Drawing.Size(84, 13);
            this.SelToppings.TabIndex = 5;
            this.SelToppings.Text = "Select Toppings";
            // 
            // SelSize
            // 
            this.SelSize.AutoSize = true;
            this.SelSize.Location = new System.Drawing.Point(22, 52);
            this.SelSize.Name = "SelSize";
            this.SelSize.Size = new System.Drawing.Size(60, 13);
            this.SelSize.TabIndex = 4;
            this.SelSize.Text = "Select Size";
            // 
            // SelPizza
            // 
            this.SelPizza.AutoSize = true;
            this.SelPizza.Location = new System.Drawing.Point(17, 18);
            this.SelPizza.Name = "SelPizza";
            this.SelPizza.Size = new System.Drawing.Size(65, 13);
            this.SelPizza.TabIndex = 3;
            this.SelPizza.Text = "Select Pizza";
            // 
            // Toppings
            // 
            this.Toppings.FormattingEnabled = true;
            this.Toppings.Items.AddRange(new object[] {
            "Toppings1",
            "Toppings2",
            "Toppings3",
            "Toppings4",
            "Toppings5"});
            this.Toppings.Location = new System.Drawing.Point(88, 95);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(121, 21);
            this.Toppings.TabIndex = 2;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(90, 7);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(188, 20);
            this.PhoneNumber.TabIndex = 1;
            // 
            // Size
            // 
            this.Size.FormattingEnabled = true;
            this.Size.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.Size.Location = new System.Drawing.Point(88, 52);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(121, 21);
            this.Size.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.PhoneNumber);
            this.panel7.Controls.Add(this.Phn);
            this.panel7.Location = new System.Drawing.Point(16, 250);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 36);
            this.panel7.TabIndex = 2;
            // 
            // Phn
            // 
            this.Phn.AutoSize = true;
            this.Phn.Location = new System.Drawing.Point(6, 13);
            this.Phn.Name = "Phn";
            this.Phn.Size = new System.Drawing.Size(78, 13);
            this.Phn.TabIndex = 0;
            this.Phn.Text = "Phone Number";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.SelToppings);
            this.panel4.Controls.Add(this.SelSize);
            this.panel4.Controls.Add(this.SelPizza);
            this.panel4.Controls.Add(this.Toppings);
            this.panel4.Controls.Add(this.Size);
            this.panel4.Controls.Add(this.Pizza);
            this.panel4.Location = new System.Drawing.Point(462, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 149);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Pizza
            // 
            this.Pizza.FormattingEnabled = true;
            this.Pizza.Items.AddRange(new object[] {
            "Hand-Tossed",
            "Pan Pizza",
            "Thin N Crispy",
            "Stuffed Crust"});
            this.Pizza.Location = new System.Drawing.Point(88, 15);
            this.Pizza.Name = "Pizza";
            this.Pizza.Size = new System.Drawing.Size(121, 21);
            this.Pizza.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(34, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 346);
            this.panel3.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Address);
            this.panel6.Controls.Add(this.AddressTxt);
            this.panel6.Location = new System.Drawing.Point(16, 73);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 142);
            this.panel6.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(9, 21);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(269, 96);
            this.Address.TabIndex = 1;
            this.Address.Text = "";
            // 
            // AddressTxt
            // 
            this.AddressTxt.AutoSize = true;
            this.AddressTxt.Location = new System.Drawing.Point(6, 4);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(45, 13);
            this.AddressTxt.TabIndex = 0;
            this.AddressTxt.Text = "Address";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.NameTxt);
            this.panel5.Location = new System.Drawing.Point(16, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 30);
            this.panel5.TabIndex = 0;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(58, 3);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(220, 20);
            this.NameTxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(36, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 399);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Make Payment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(462, 271);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(236, 81);
            this.panel8.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cost for your selected pizza";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Build Pizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place youe Pizza Order";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(277, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 32);
            this.panel2.TabIndex = 7;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Order";
            this.Text = "Order";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelToppings;
        private System.Windows.Forms.Label SelSize;
        private System.Windows.Forms.Label SelPizza;
        private System.Windows.Forms.ComboBox Toppings;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.ComboBox Size;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Phn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox Pizza;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.Label AddressTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}
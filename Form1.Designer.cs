namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chb_Coffee = new CheckBox();
            chb_Greentea = new CheckBox();
            tb_Coffee_Price = new TextBox();
            tb_Coffee_Quantity = new TextBox();
            tb_GreenTea_Price = new TextBox();
            tb_GreenTea_Quantity = new TextBox();
            tb_total = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            SuspendLayout();
            // 
            // chb_Coffee
            // 
            chb_Coffee.AutoSize = true;
            chb_Coffee.Location = new Point(84, 59);
            chb_Coffee.Name = "chb_Coffee";
            chb_Coffee.Size = new Size(61, 19);
            chb_Coffee.TabIndex = 0;
            chb_Coffee.Text = "Coffee";
            chb_Coffee.UseVisualStyleBackColor = true;
            chb_Coffee.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chb_Greentea
            // 
            chb_Greentea.AutoSize = true;
            chb_Greentea.Location = new Point(84, 84);
            chb_Greentea.Name = "chb_Greentea";
            chb_Greentea.Size = new Size(77, 19);
            chb_Greentea.TabIndex = 1;
            chb_Greentea.Text = "Green Tea";
            chb_Greentea.UseVisualStyleBackColor = true;
            chb_Greentea.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // tb_Coffee_Price
            // 
            tb_Coffee_Price.Location = new Point(204, 55);
            tb_Coffee_Price.Name = "tb_Coffee_Price";
            tb_Coffee_Price.Size = new Size(100, 23);
            tb_Coffee_Price.TabIndex = 2;
            tb_Coffee_Price.TextChanged += textBox1_TextChanged;
            // 
            // tb_Coffee_Quantity
            // 
            tb_Coffee_Quantity.Location = new Point(323, 55);
            tb_Coffee_Quantity.Name = "tb_Coffee_Quantity";
            tb_Coffee_Quantity.Size = new Size(100, 23);
            tb_Coffee_Quantity.TabIndex = 3;
            tb_Coffee_Quantity.Tag = "";
            tb_Coffee_Quantity.TextChanged += textBox2_TextChanged;
            // 
            // tb_GreenTea_Price
            // 
            tb_GreenTea_Price.Location = new Point(204, 84);
            tb_GreenTea_Price.Name = "tb_GreenTea_Price";
            tb_GreenTea_Price.Size = new Size(100, 23);
            tb_GreenTea_Price.TabIndex = 4;
            tb_GreenTea_Price.Tag = "";
            tb_GreenTea_Price.TextChanged += textBox3_TextChanged;
            // 
            // tb_GreenTea_Quantity
            // 
            tb_GreenTea_Quantity.Location = new Point(323, 84);
            tb_GreenTea_Quantity.Name = "tb_GreenTea_Quantity";
            tb_GreenTea_Quantity.Size = new Size(100, 23);
            tb_GreenTea_Quantity.TabIndex = 5;
            tb_GreenTea_Quantity.TextChanged += textBox4_TextChanged;
            // 
            // tb_total
            // 
            tb_total.Location = new Point(619, 57);
            tb_total.Name = "tb_total";
            tb_total.Size = new Size(100, 23);
            tb_total.TabIndex = 7;
            tb_total.Tag = "";
            tb_total.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 65);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 8;
            label1.Text = "Total";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(446, 55);
            button1.Name = "button1";
            button1.Size = new Size(94, 110);
            button1.TabIndex = 6;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(568, 94);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 10;
            label2.Text = "Cash";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(619, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.Tag = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 123);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Change";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(619, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            textBox2.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 152);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 14;
            label4.Text = "1000";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(619, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            textBox3.Tag = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(568, 181);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 16;
            label5.Text = "500";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(619, 173);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 15;
            textBox4.Tag = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 210);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 18;
            label6.Text = "100";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(619, 202);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 17;
            textBox5.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(568, 239);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 20;
            label7.Text = "50";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(619, 231);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 19;
            textBox6.Tag = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(568, 268);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 22;
            label8.Text = "20";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(619, 260);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 21;
            textBox7.Tag = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(568, 297);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 24;
            label9.Text = "10";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(619, 289);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 23;
            textBox8.Tag = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(568, 326);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 26;
            label10.Text = "5";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(619, 318);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 25;
            textBox9.Tag = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(568, 355);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 28;
            label11.Text = "1";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(619, 347);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 27;
            textBox10.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(tb_total);
            Controls.Add(button1);
            Controls.Add(tb_GreenTea_Quantity);
            Controls.Add(tb_GreenTea_Price);
            Controls.Add(tb_Coffee_Quantity);
            Controls.Add(tb_Coffee_Price);
            Controls.Add(chb_Greentea);
            Controls.Add(chb_Coffee);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chb_Coffee;
        private CheckBox chb_Greentea;
        private TextBox tb_Coffee_Price;
        private TextBox tb_Coffee_Quantity;
        private TextBox tb_GreenTea_Price;
        private TextBox tb_GreenTea_Quantity;
        private TextBox tb_total;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox10;
    }
}

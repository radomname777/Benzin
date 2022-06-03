namespace WinFormsApp8
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Oil = new System.Windows.Forms.GroupBox();
            this.PriceLtxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_liter = new System.Windows.Forms.TextBox();
            this.literPrice = new System.Windows.Forms.RadioButton();
            this.liter = new System.Windows.Forms.RadioButton();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Benzin = new System.Windows.Forms.Label();
            this.kafe = new System.Windows.Forms.GroupBox();
            this.cola_txt = new System.Windows.Forms.TextBox();
            this.fri_txt = new System.Windows.Forms.TextBox();
            this.gamburger_txt = new System.Windows.Forms.TextBox();
            this.hotdog_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.coco = new System.Windows.Forms.CheckBox();
            this.fri = new System.Windows.Forms.CheckBox();
            this.Gamburger = new System.Windows.Forms.CheckBox();
            this.Hotdog = new System.Windows.Forms.CheckBox();
            this.Sum = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Oil.SuspendLayout();
            this.kafe.SuspendLayout();
            this.Sum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Oil
            // 
            this.Oil.BackColor = System.Drawing.Color.Transparent;
            this.Oil.Controls.Add(this.PriceLtxt);
            this.Oil.Controls.Add(this.label3);
            this.Oil.Controls.Add(this.txt_price);
            this.Oil.Controls.Add(this.txt_liter);
            this.Oil.Controls.Add(this.literPrice);
            this.Oil.Controls.Add(this.liter);
            this.Oil.Controls.Add(this.Price_txt);
            this.Oil.Controls.Add(this.label1);
            this.Oil.Controls.Add(this.comboBox1);
            this.Oil.Controls.Add(this.Benzin);
            this.Oil.Location = new System.Drawing.Point(12, 22);
            this.Oil.Name = "Oil";
            this.Oil.Size = new System.Drawing.Size(230, 277);
            this.Oil.TabIndex = 0;
            this.Oil.TabStop = false;
            this.Oil.Text = "Oil";
            // 
            // PriceLtxt
            // 
            this.PriceLtxt.AutoSize = true;
            this.PriceLtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLtxt.ForeColor = System.Drawing.Color.Black;
            this.PriceLtxt.Location = new System.Drawing.Point(200, 257);
            this.PriceLtxt.Name = "PriceLtxt";
            this.PriceLtxt.Size = new System.Drawing.Size(30, 17);
            this.PriceLtxt.TabIndex = 11;
            this.PriceLtxt.Text = "AZE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "0,00";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Location = new System.Drawing.Point(87, 160);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(121, 23);
            this.txt_price.TabIndex = 7;
            this.txt_price.Tag = "2";
            this.txt_price.Text = "0";
            this.txt_price.Visible = false;
            // 
            // txt_liter
            // 
            this.txt_liter.BackColor = System.Drawing.Color.White;
            this.txt_liter.Location = new System.Drawing.Point(87, 119);
            this.txt_liter.Name = "txt_liter";
            this.txt_liter.Size = new System.Drawing.Size(121, 23);
            this.txt_liter.TabIndex = 6;
            this.txt_liter.Text = "0";
            this.txt_liter.Visible = false;
            // 
            // literPrice
            // 
            this.literPrice.BackColor = System.Drawing.Color.Transparent;
            this.literPrice.FlatAppearance.BorderSize = 5;
            this.literPrice.ForeColor = System.Drawing.Color.White;
            this.literPrice.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.literPrice.Location = new System.Drawing.Point(31, 160);
            this.literPrice.Name = "literPrice";
            this.literPrice.Size = new System.Drawing.Size(69, 19);
            this.literPrice.TabIndex = 5;
            this.literPrice.TabStop = true;
            this.literPrice.Tag = "2";
            this.literPrice.Text = "Price";
            this.literPrice.UseVisualStyleBackColor = false;
            this.literPrice.CheckedChanged += new System.EventHandler(this.Radiobutton_CheckedChanged);
            // 
            // liter
            // 
            this.liter.AutoSize = true;
            this.liter.ForeColor = System.Drawing.Color.White;
            this.liter.Location = new System.Drawing.Point(31, 123);
            this.liter.Name = "liter";
            this.liter.Size = new System.Drawing.Size(48, 19);
            this.liter.TabIndex = 4;
            this.liter.TabStop = true;
            this.liter.Tag = "1";
            this.liter.Text = "Liter";
            this.liter.UseVisualStyleBackColor = true;
            this.liter.CheckedChanged += new System.EventHandler(this.Radiobutton_CheckedChanged);
            // 
            // Price_txt
            // 
            this.Price_txt.BackColor = System.Drawing.Color.White;
            this.Price_txt.Location = new System.Drawing.Point(87, 78);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.ReadOnly = true;
            this.Price_txt.Size = new System.Drawing.Size(121, 23);
            this.Price_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A-92",
            "A - 95",
            "Dizel"});
            this.comboBox1.Location = new System.Drawing.Point(87, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Benzin
            // 
            this.Benzin.AutoSize = true;
            this.Benzin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Benzin.Location = new System.Drawing.Point(17, 40);
            this.Benzin.Name = "Benzin";
            this.Benzin.Size = new System.Drawing.Size(45, 17);
            this.Benzin.TabIndex = 0;
            this.Benzin.Text = "Benzin";
            // 
            // kafe
            // 
            this.kafe.BackColor = System.Drawing.Color.Transparent;
            this.kafe.Controls.Add(this.cola_txt);
            this.kafe.Controls.Add(this.fri_txt);
            this.kafe.Controls.Add(this.gamburger_txt);
            this.kafe.Controls.Add(this.hotdog_txt);
            this.kafe.Controls.Add(this.label4);
            this.kafe.Controls.Add(this.label2);
            this.kafe.Controls.Add(this.textBox7);
            this.kafe.Controls.Add(this.textBox6);
            this.kafe.Controls.Add(this.textBox5);
            this.kafe.Controls.Add(this.textBox4);
            this.kafe.Controls.Add(this.coco);
            this.kafe.Controls.Add(this.fri);
            this.kafe.Controls.Add(this.Gamburger);
            this.kafe.Controls.Add(this.Hotdog);
            this.kafe.Location = new System.Drawing.Point(284, 22);
            this.kafe.Name = "kafe";
            this.kafe.Size = new System.Drawing.Size(230, 277);
            this.kafe.TabIndex = 1;
            this.kafe.TabStop = false;
            this.kafe.Text = "Kafe";
            // 
            // cola_txt
            // 
            this.cola_txt.BackColor = System.Drawing.Color.White;
            this.cola_txt.Location = new System.Drawing.Point(171, 160);
            this.cola_txt.Name = "cola_txt";
            this.cola_txt.ReadOnly = true;
            this.cola_txt.Size = new System.Drawing.Size(53, 23);
            this.cola_txt.TabIndex = 11;
            this.cola_txt.Tag = "4";
            this.cola_txt.Text = "1";
            // 
            // fri_txt
            // 
            this.fri_txt.BackColor = System.Drawing.Color.White;
            this.fri_txt.Location = new System.Drawing.Point(171, 118);
            this.fri_txt.Name = "fri_txt";
            this.fri_txt.ReadOnly = true;
            this.fri_txt.Size = new System.Drawing.Size(53, 23);
            this.fri_txt.TabIndex = 9;
            this.fri_txt.Tag = "3";
            this.fri_txt.Text = "1";
            // 
            // gamburger_txt
            // 
            this.gamburger_txt.BackColor = System.Drawing.Color.White;
            this.gamburger_txt.Location = new System.Drawing.Point(171, 77);
            this.gamburger_txt.Name = "gamburger_txt";
            this.gamburger_txt.ReadOnly = true;
            this.gamburger_txt.Size = new System.Drawing.Size(53, 23);
            this.gamburger_txt.TabIndex = 7;
            this.gamburger_txt.Tag = "2";
            this.gamburger_txt.Text = "1";
            // 
            // hotdog_txt
            // 
            this.hotdog_txt.BackColor = System.Drawing.Color.White;
            this.hotdog_txt.Location = new System.Drawing.Point(171, 37);
            this.hotdog_txt.Name = "hotdog_txt";
            this.hotdog_txt.ReadOnly = true;
            this.hotdog_txt.Size = new System.Drawing.Size(53, 23);
            this.hotdog_txt.TabIndex = 5;
            this.hotdog_txt.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(200, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "AZE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "0,00";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(109, 160);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(53, 23);
            this.textBox7.TabIndex = 10;
            this.textBox7.Tag = "44";
            this.textBox7.Text = "4,40";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(109, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(53, 23);
            this.textBox6.TabIndex = 8;
            this.textBox6.Tag = "33";
            this.textBox6.Text = "7,20";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(109, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(53, 23);
            this.textBox5.TabIndex = 6;
            this.textBox5.Tag = "22";
            this.textBox5.Text = "5,40";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(109, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(53, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Tag = "11";
            this.textBox4.Text = "4,00";
            // 
            // coco
            // 
            this.coco.AutoSize = true;
            this.coco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coco.ForeColor = System.Drawing.Color.White;
            this.coco.Location = new System.Drawing.Point(6, 163);
            this.coco.Name = "coco";
            this.coco.Size = new System.Drawing.Size(93, 24);
            this.coco.TabIndex = 3;
            this.coco.Tag = "4,40";
            this.coco.Text = "coko cola";
            this.coco.UseVisualStyleBackColor = true;
            this.coco.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fri
            // 
            this.fri.AutoSize = true;
            this.fri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fri.ForeColor = System.Drawing.Color.White;
            this.fri.Location = new System.Drawing.Point(6, 122);
            this.fri.Name = "fri";
            this.fri.Size = new System.Drawing.Size(110, 24);
            this.fri.TabIndex = 2;
            this.fri.Tag = "7,20";
            this.fri.Text = "French fries";
            this.fri.UseVisualStyleBackColor = true;
            this.fri.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Gamburger
            // 
            this.Gamburger.AutoSize = true;
            this.Gamburger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Gamburger.ForeColor = System.Drawing.Color.White;
            this.Gamburger.Location = new System.Drawing.Point(6, 81);
            this.Gamburger.Name = "Gamburger";
            this.Gamburger.Size = new System.Drawing.Size(108, 24);
            this.Gamburger.TabIndex = 1;
            this.Gamburger.Tag = "5,40";
            this.Gamburger.Text = "Gamburger";
            this.Gamburger.UseVisualStyleBackColor = true;
            this.Gamburger.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Hotdog
            // 
            this.Hotdog.AutoSize = true;
            this.Hotdog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hotdog.ForeColor = System.Drawing.Color.White;
            this.Hotdog.Location = new System.Drawing.Point(6, 40);
            this.Hotdog.Name = "Hotdog";
            this.Hotdog.Size = new System.Drawing.Size(85, 24);
            this.Hotdog.TabIndex = 0;
            this.Hotdog.Tag = "4";
            this.Hotdog.Text = "Hot dog";
            this.Hotdog.UseVisualStyleBackColor = true;
            this.Hotdog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.Color.Transparent;
            this.Sum.CausesValidation = false;
            this.Sum.Controls.Add(this.pictureBox1);
            this.Sum.Controls.Add(this.label7);
            this.Sum.Controls.Add(this.label6);
            this.Sum.Controls.Add(this.button1);
            this.Sum.ForeColor = System.Drawing.Color.Red;
            this.Sum.Location = new System.Drawing.Point(12, 299);
            this.Sum.Name = "Sum";
            this.Sum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sum.Size = new System.Drawing.Size(502, 104);
            this.Sum.TabIndex = 1;
            this.Sum.TabStop = false;
            this.Sum.Text = "sum";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp8.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(422, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "AZE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(342, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "0,00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(157, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Sum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 415);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.kafe);
            this.Controls.Add(this.Oil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Oil.ResumeLayout(false);
            this.Oil.PerformLayout();
            this.kafe.ResumeLayout(false);
            this.kafe.PerformLayout();
            this.Sum.ResumeLayout(false);
            this.Sum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Oil;
        private ComboBox comboBox1;
        private Label Benzin;
        private GroupBox kafe;
        private GroupBox Sum;
        private Label label1;
        private RadioButton literPrice;
        private RadioButton liter;
        private TextBox Price_txt;
        private TextBox txt_price;
        private TextBox txt_liter;
        private Label PriceLtxt;
        private Label label3;
        private CheckBox Gamburger;
        private CheckBox Hotdog;
        private Label label4;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private CheckBox coco;
        private CheckBox fri;
        private Label label7;
        private Label label6;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private TextBox cola_txt;
        private TextBox fri_txt;
        private TextBox gamburger_txt;
        private TextBox hotdog_txt;
        private PictureBox pictureBox1;
    }
}
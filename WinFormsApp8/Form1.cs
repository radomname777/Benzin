using System.Text.RegularExpressions;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Mybool { get; set; }
        bool Mybool2 = false;
 
        private void Price(int num)
        {
            switch (num)
            {
                case 0: Price_txt.Text = "1,00";break;
                case 1: Price_txt.Text = "1,60";break;
                case 2: Price_txt.Text = "0,80";break;
                default: Price_txt.Text="0,00"; break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mybool2 = true;
            if (sender is ComboBox com)
            {
                Price(com.SelectedIndex);
            }
        }
        void None()
        {
            txt_liter.Visible = false; txt_liter.Text = "0";
            txt_price.Visible = false; txt_liter.Text = "0";
        }
        
        int time = 800;
        private void Timer_Tick2(object? sender, EventArgs e)
        {
            int num = 0;
            double count = 0;
            foreach (Control gb in kafe.Controls)
            {
                if (gb is CheckBox CB)
                {
                    if (CB.Checked)
                    {
                        num++;            
                        try
                        {
                            switch (CB.Name)
                            {
                                
                                case "Hotdog":
                                    count += 4.00 *Convert.ToInt32(hotdog_txt.Text);
                                    break;
                                case "Gamburger":
                                    count += 5.40 * Convert.ToInt32(gamburger_txt.Text);
                                    break;
                                case "fri":
                                    count += 7.20 * Convert.ToInt32(fri_txt.Text);
                                    break;
                                case "coco":
                                    count += 4.40 * Convert.ToInt32(cola_txt.Text);
                                    break;
                            }

                        }
                        catch (Exception){return;}
                        label2.Text = count.ToString();
                        while (label2.Text.Length > 4) label2.Text = label2.Text.Remove(label2.Text.Length - 1);
                    }

                }
            }
            if (num==0) label2.Text = "0,00";
        }
        decimal numbersum = 0;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            try
            {
                if (Mybool)label3.Text = (Convert.ToDecimal(txt_liter.Text) * Convert.ToDecimal(Price_txt.Text)).ToString();
                else 
                {
                    numbersum = Convert.ToDecimal(txt_price.Text);
                    label3.Text = (Convert.ToDecimal(txt_price.Text) / Convert.ToDecimal(Price_txt.Text)).ToString();
                }
                while (label3.Text.Length > 4)label3.Text = label3.Text.Remove(label3.Text.Length-1);
            }
            catch (Exception){return; }
        }
        private void Radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Mybool2)
            {

            }
            if (sender is RadioButton rbtn)
            {
                if (Mybool2)
                {

                    None();
                    txt_liter.Visible = false;
                    txt_price.Visible = false;
                    switch (rbtn.Tag)
                    {
                        case "1":
                            txt_liter.Visible = true; Mybool = true; PriceLtxt.Text = "Aze";
                            break;
                        case "2":
                            txt_price.Visible = true; Mybool = false; PriceLtxt.Text = "liter";
                            break;
                    }
                    timer1.Interval = time;
                    timer1.Tick += Timer_Tick;
                    timer1.Start();
                }
                else rbtn.Checked = false;
                

            }
            time += 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Mybool)
                label6.Text = (Convert.ToDecimal(txt_price.Text) + Convert.ToDecimal(label2.Text)).ToString();
            else
                label6.Text =(Convert.ToDecimal(label2.Text) + Convert.ToDecimal(label3.Text)).ToString();
            timer1.Stop();
            if (label6.Text!="0,00")MessageBox.Show($"Total Price: {label6.Text}", "Thank you for shopping with us");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            if (sender is CheckBox CB)
            {
                switch (CB.Name)
                {
                    case "Hotdog":
                        hotdog_txt.ReadOnly = !CB.Checked;
                        break;
                    case "Gamburger":
                        gamburger_txt.ReadOnly = !CB.Checked;
                        break;
                    case "fri":
                        fri_txt.ReadOnly = !CB.Checked;
                        break;
                    case "coco":
                        cola_txt.ReadOnly = !CB.Checked;
                        break;
                }
                timer1.Interval = time;
                timer1.Tick += Timer_Tick2;
                timer1.Start();
            }
            time++;
        }
    }
}
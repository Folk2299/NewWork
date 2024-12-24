namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get amount
            string strCoffeePrice = this.tb_Coffee_Price.Text;
            string strGreenTeaPrice = this.tb_GreenTea_Price.Text; 
            //get price
            string strCoffeeQuntity = this.tb_Coffee_Quantity.Text;
            string strGreenTeaQuntity = this.tb_GreenTea_Quantity.Text;

            int iCoffeePrice = 1;
            int iCoffeeQuantity = 1;
            int iGreenTeaPrice = 1;
            int iGreenTeaQuantity = 1;

            try
            {
                // convert string to int
                if (chb_Coffee.Checked)
                {
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuntity);
                }
                if (chb_Greentea.Checked)
                {
                    iGreenTeaPrice = int.Parse(strGreenTeaPrice);
                    iGreenTeaQuantity = int.Parse(strGreenTeaQuntity);
                }

            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
                iGreenTeaPrice = 0;
                iGreenTeaQuantity = 0;
            }
            
            //calculate total
            int iTotal = iCoffeePrice * iCoffeeQuantity + iGreenTeaPrice * iGreenTeaQuantity;
            //display total
            tb_total.Text = iTotal.ToString();


        }
    }
}

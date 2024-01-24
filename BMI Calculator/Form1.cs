namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight, bmi;

            if(double.TryParse(textBox1.Text, out weight) && double.TryParse(textBox2.Text, out height))
            {
                bmi = weight / Math.Pow(height, 2);

                textBox3.Text = bmi.ToString();

                if(bmi < 18)
                {
                    textBox4.Text = "You're underweight";
                }
                else if(bmi <= 18 &&  bmi < 26)
                {
                    textBox4.Text = "You're normal";
                }
                else
                {
                    textBox4.Text = "You're overweight";
                }
            }
        }
    }
}

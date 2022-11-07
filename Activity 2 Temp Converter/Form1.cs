namespace Activity_2_Temp_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxferhenheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_kelven_Click(object sender, EventArgs e)
        {

        }

        private void button_celsius_Click(object sender, EventArgs e)
        {
            double c = 0;
            c = double.Parse(textBox_celsius.Text);
            double f = 9/5 + 32;
            textBox_fahrenheight.Text = f.ToString();
        }

        private void button_fahrenheight_Click(object sender, EventArgs e)
        {
            //define value of fahrenheight
            // refered to goolge to determin conversions
            
         double f = 0;

            //converts string to a float 
            f = double.Parse(textBox_fahrenheight.Text);

           // creating a float value tofor string
            double c = 5f / 9f * (f - 32);
            textBox_celsius.Text = c.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
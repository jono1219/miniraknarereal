namespace miniräknarereal
{
    public partial class Form1 : Form
    {
        double forsta_talet = 0;
        string raknesatt = "";
        double minnesparad = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e) // Plus
        {
            if (double.TryParse(textBox1.Text, out forsta_talet))
            {
                raknesatt = "+";
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e) // Gånger
        {
            if (double.TryParse(textBox1.Text, out forsta_talet))
            {
                raknesatt = "*";
                textBox1.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e) // Minus
        {
            if (double.TryParse(textBox1.Text, out forsta_talet))
            {
                raknesatt = "-";
                textBox1.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e) // Division
        {
            if (double.TryParse(textBox1.Text, out forsta_talet))
            {
                raknesatt = "/";
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e) // Lika med
        {
            double andra_talet;
            string input = textBox1.Text.Trim().ToLower();

            
            if (input == "oh")
                raknesatt = "+";
            else if (input == "i")
                raknesatt = "-";
            else if (input == "g")
                raknesatt = "*";
            else if (input == "d")
                raknesatt = "/";

            if (double.TryParse(input, out andra_talet))
            {
                double resultat = 0;
                switch (raknesatt)
                {
                    case "+":
                        resultat = forsta_talet + andra_talet;
                        break;
                    case "-":
                        resultat = forsta_talet - andra_talet;
                        break;
                    case "*":
                        resultat = forsta_talet * andra_talet;
                        break;
                    case "/":
                        if (andra_talet != 0)
                            resultat = forsta_talet / andra_talet;
                        else
                        {
                            MessageBox.Show("Division med noll är inte tillåten!");
                            return;
                        }
                        break;
                }
                textBox1.Text = resultat.ToString();
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out forsta_talet))
            {
                textBox1.Text = textBox1.Text + ",";

            }
        }



        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3.14";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

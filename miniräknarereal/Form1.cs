using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;

namespace miniräknarereal
{
    public partial class Form1 : Form
    {
        double forsta_talet = 0;
        string raknesatt = "";
        double minne = 0;

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
            forsta_talet = Convert.ToDouble(textBox1.Text);
            {
                raknesatt = "+";
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e) // Gånger
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
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
            forsta_talet = Convert.ToDouble(textBox1.Text);
            {
                raknesatt = "-";
                textBox1.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e) // Division
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            {
                raknesatt = "/";
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e) // Lika med
        {

            double andra_talet = Convert.ToDouble(textBox1.Text = Convert.ToString(textBox1.Text));
            if (raknesatt == "+")
            {
                textBox1.Text = (forsta_talet + andra_talet).ToString();
            }
            else if (raknesatt == "-")
            {
                textBox1.Text = (forsta_talet - andra_talet).ToString();
            }

            else if (raknesatt == "*")
            {
                textBox1.Text = (forsta_talet * andra_talet).ToString();
            }
            else if (raknesatt == "/")
            {
                textBox1.Text = (forsta_talet / andra_talet).ToString();
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
            textBox1.Text = "3,14";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = minne.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            double tal = Convert.ToDouble(textBox1.Text); // läser texten från rutan och gör om texten till ett tal av typen double (Decimla tal) sparar det i en lokal variabel
            double kvadrat = tal * tal; // räknar tal gånger tal om tal är 5 blir kvadrat 25 5*5 = 25
            textBox1.Text = kvadrat.ToString(); // gör om resultat kvadrat ett double till text med string och visar resultatet genom att sätta textBox1.text till den texten
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            minne = Convert.ToDouble(textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            minne = 0; //nollställ minnet
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double tal = Convert.ToDouble(textBox1.Text); // hämtar talet i rutan
            double rot = Math.Sqrt(tal); // räkna kvadratrotten
            textBox1.Text = rot.ToString(); // visar svaret i rutan
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int tal = Convert.ToInt32(textBox1.Text); // hämta talet som heltal
            textBox1.Text = Convert.ToString(tal, 2); // gör om till binärt bas 2
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int tal = Convert.ToInt32(textBox1.Text, 2); // hämta binärt som heltal
            textBox1.Text = tal.ToString(); // till text vanligt tal
        }
    }
}

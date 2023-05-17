namespace WinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numberInput1 = int.Parse(textBox1.Text);
            int numberInput2 = int.Parse(textBox2.Text);
            int result = numberInput1 / numberInput2;
            textBox3.Text = result.ToString();
            listBox1.Items.Add(numberInput1 + "/" + numberInput2 + "=" + " " + result);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int numberInput1 = int.Parse(textBox1.Text);
            int numberInput2 = int.Parse(textBox2.Text);
            int result = numberInput1 + numberInput2;
            textBox3.Text = result.ToString();
            listBox1.Items.Add(numberInput1 + "+" + numberInput2 + "=" + " " + result);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button13_Click(object sender, EventArgs e)
        {
            int numberInput1 = int.Parse(textBox1.Text);
            int numberInput2 = int.Parse(textBox2.Text);
            int result = numberInput1 * numberInput2;
            textBox3.Text = result.ToString();
            listBox1.Items.Add(numberInput1 + "*" + numberInput2 + "=" + " " + result);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int numberInput1 = int.Parse(textBox1.Text);
            int numberInput2 = int.Parse(textBox2.Text);
            int result = numberInput1 - numberInput2;
            textBox3.Text = result.ToString();
            listBox1.Items.Add(numberInput1 + " - " + numberInput2 + "=" + " " + result);
        }
    }
}
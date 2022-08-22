namespace maskedtextBoxtan_listBoxa_aktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("ISTANBUL");
            comboBox1.Items.Add("ANKARA");

            comboBox2.Items.Add("ISTANBUL");
            comboBox2.Items.Add("ANKARA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(maskedTextBox2.Text);
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(dateTimePicker1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text + " " + textBox4.Text
                + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text + " " 
                + comboBox2.Text + " " + dateTimePicker2.Text);
        }
    }
}
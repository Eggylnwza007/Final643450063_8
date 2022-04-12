using System.Text;
namespace record
{
    public partial class Payment : Form
    {
        public Payment(int price)
        {
            InitializeComponent();
            this.textBox1.Text = price.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            int intInput = int.Parse(input);

            int price = int.Parse(this.textBox1.Text);
            this.textBox3.Text = (intInput - price).ToString();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}


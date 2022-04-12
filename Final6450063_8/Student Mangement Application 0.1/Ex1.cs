using System.Text;

namespace record
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++) {
                    string RAW = readAllLine[i];
                    string[] Splied = RAW.Split(',');
                    dataGridView1.Rows.Add(Splied[0], Splied[1], Splied[2]);

                    //addDatatoGridView(student);
                     //TODO: Add Student object to DataGridView
                }

                //TODO : calculate max, min,gpax
            }
            
        
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = this.dataGridView1.Rows[0].Cells[0].Value.ToString();

            string strData = null;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if(saveFileDialog.ShowDialog() == DialogResult.OK) {
                if(saveFileDialog.FileName != null) {

                    for (int Rows = 0; Rows < dataGridView1.Rows.Count; Rows++)
                    {
                        for (int column = 0; column < dataGridView1.Columns.Count; column++) {
                            if(dataGridView1.Rows[Rows].Cells[column].Value != null)
                            {
                                strData += dataGridView1.Rows[Rows].Cells[column].Value.ToString() + ",";
                                if (column == dataGridView1.Columns.Count - 1)
                                    strData += "\r\n";
                                //todo: save from dataGridView1 to variable
                            }
                        }
                    }

                    //save File
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);


                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                if (Double.TryParse(textBox3.Text, out double x))
                {
                        GUI info = new GUI(textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text).ToString());
                    dataGridView1.Rows.Add(info.Namelist, info.Amount.ToString("N"),info.Type);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = ""; // เว้นบรรทัด ในช่องของ comboBox

                }
                else
                {
                    MessageBox.Show("กรูณาระบุข้อมูลจำนวนเป็นตัวเลข", "นาจ๊ะ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                double allg = 0;
                for (int x = 0; x < dataGridView1.Rows.Count; x++)
                {
                    allg += Convert .ToDouble(dataGridView1.Rows[x].Cells[1].Value);
                }
                textBox5.Text = allg.ToString();

                double allg2 = 0;
                for (int x = 0; x < dataGridView1.Rows.Count; x++)
                {
                    allg2 += Convert.ToDouble(dataGridView1.Rows[x].Cells[2].Value);
                }
                textBox1.Text = allg2.ToString();

                textBox6.Text = allg.ToString() + allg2.ToString();
            }
        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                double allg = 0; // การรับข้อมูลตัวเลข ที่เก็บใน allg = 0 เริ่มแต่จาก 0
                for (int x = 0; x < dataGridView1.Rows.Count; x++) // for คำสั่ง ลูบ int คือแปลงค่าเป็นตัวเลข x = 0; x < +1+2+3..จนสุดแถว
                {
                    allg += Convert.ToDouble(dataGridView1.Rows[x].Cells[1].Value); // Convert 
                }
                textBox5.Text = allg.ToString();

                double allg2 = 0; // การรับข้อมูลตัวเลข ที่เก็บใน allg = 0 เริ่มแต่จาก 0
                for (int x = 0; x < dataGridView1.Rows.Count; x++) // for คำสั่ง ลูบ int คือแปลงค่าเป็นตัวเลข x = 0; x < +1+2+3..จนสุดแถว
                {
                    allg2 += Convert.ToDouble(dataGridView1.Rows[x].Cells[2].Value);
                }
                textBox1.Text = allg.ToString();

                textBox6.Text = allg.ToString() + allg2.ToString();



            }
            else
            {
                textBox5.Text = "0";
                textBox1.Text = "0";
                textBox6.Text = "0";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); //ลบข้อมูลใน Rows แถวแนว y หรือ ตั้ง เฉพาะใน dataGridView1
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex1 mm = new Ex1();
            int price = 0;

            Payment p = new Payment(price);
            p.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
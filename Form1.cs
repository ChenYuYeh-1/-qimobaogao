using System;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            comboBoxType.Items.Add("�ʪ�");
            comboBoxType.Items.Add("��`�Ϋ~");
            comboBoxType.SelectedIndex = 0;
            label2.Text = "�����`�B $0.00";

            timer1.Enabled = true;
            // ?�m�w?���D??�j�]?���H�C���D?�@��?�ҡA�i�H���u�ݭn?��^
            timer1.Interval = (int)TimeSpan.FromDays(1).TotalMilliseconds;
            // ? timer1_Tick �ƥ��O Tick �ƥ�??
            timer1.Tick += timer1_Tick;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            if (currentDate.Day == 1)
            {
                // ���m����`�B
                totalAmount = 0;
                label2.Text = "�����`�B $0.00";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            if (currentDate.Day == 1)
            {
                // ���m����`�B
                totalAmount = 0;
                label2.Text = "�����`�B $0.00";
            }
        }

        private void dataGridViewRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private decimal totalAmount = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string date = dateTimePickerDate.Value.ToShortDateString();
            string type = comboBoxType.SelectedItem.ToString();
            string amountText = textBoxAmount.Text;

            if (!string.IsNullOrWhiteSpace(amountText) && decimal.TryParse(amountText, out decimal amount))
            {
                dataGridViewRecords.Rows.Add(date, type, amountText);
                textBoxAmount.Clear();

                // ��s�`�B
                totalAmount += amount;
                label2.Text = $"�����`�B: ${totalAmount:0.00}";
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRecords.SelectedRows)
            {

                dataGridViewRecords.Rows.Remove(row);
                // ��R���O���ɦP�ɧ�s�`�B
                if (decimal.TryParse(row.Cells[2].Value.ToString(), out decimal amount))
                {
                    totalAmount -= amount;
                    label2.Text = $"Total Amount: ${totalAmount:0.00}";
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save an Expense File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine("Date,Type,Amount");
                        foreach (DataGridViewRow row in dataGridViewRecords.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                sw.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value}");
                            }
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CalculateMonthlyTotal()
        {
            Dictionary<string, decimal> monthlyTotal = new Dictionary<string, decimal>();

            foreach (DataGridViewRow row in dataGridViewRecords.Rows)
            {
                if (!row.IsNewRow)
                {
                    string month = row.Cells["Month"].Value.ToString();
                    decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);

                    if (!monthlyTotal.ContainsKey(month))
                    {
                        monthlyTotal[month] = amount;
                    }
                    else
                    {
                        monthlyTotal[month] += amount;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(totalAmount);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
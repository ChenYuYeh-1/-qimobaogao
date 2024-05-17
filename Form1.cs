using System;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            comboBoxType.Items.Add("購物");
            comboBoxType.Items.Add("日常用品");
            comboBoxType.SelectedIndex = 0;
            label2.Text = "本月總額 $0.00";

            timer1.Enabled = true;
            // ?置定?器触??隔（?里以每天触?一次?例，可以根据需要?整）
            timer1.Interval = (int)TimeSpan.FromDays(1).TotalMilliseconds;
            // ? timer1_Tick 事件与 Tick 事件??
            timer1.Tick += timer1_Tick;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            if (currentDate.Day == 1)
            {
                // 重置月度總額
                totalAmount = 0;
                label2.Text = "本月總額 $0.00";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            if (currentDate.Day == 1)
            {
                // 重置月度總額
                totalAmount = 0;
                label2.Text = "本月總額 $0.00";
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

                // 更新總額
                totalAmount += amount;
                label2.Text = $"本月總額: ${totalAmount:0.00}";
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
                // 當刪除記錄時同時更新總額
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
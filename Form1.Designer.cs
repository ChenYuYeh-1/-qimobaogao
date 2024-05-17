namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewRecords = new DataGridView();
            日期 = new DataGridViewTextBoxColumn();
            項目 = new DataGridViewTextBoxColumn();
            金額 = new DataGridViewTextBoxColumn();
            textBoxAmount = new TextBox();
            comboBoxType = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRecords
            // 
            dataGridViewRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecords.Columns.AddRange(new DataGridViewColumn[] { 日期, 項目, 金額 });
            dataGridViewRecords.Location = new Point(404, 9);
            dataGridViewRecords.Name = "dataGridViewRecords";
            dataGridViewRecords.Size = new Size(339, 432);
            dataGridViewRecords.TabIndex = 0;
            dataGridViewRecords.CellContentClick += dataGridViewRecords_CellContentClick;
            // 
            // 日期
            // 
            日期.HeaderText = "日期";
            日期.Name = "日期";
            // 
            // 項目
            // 
            項目.HeaderText = "項目";
            項目.Name = "項目";
            // 
            // 金額
            // 
            金額.HeaderText = "金額";
            金額.Name = "金額";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(20, 90);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 1;
            // 
            // comboBoxType
            // 
            comboBoxType.AutoCompleteCustomSource.AddRange(new string[] { "飲食", "日常用品", "購物", "寵物", "定期費用", "娛樂", "交通" });
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "飲食", "定期費用", "交通" });
            comboBoxType.Location = new Point(126, 90);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 2;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(20, 61);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(227, 23);
            dateTimePickerDate.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(262, 60);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "添加";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(262, 89);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "刪除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(262, 118);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "保存";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 14);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "總額";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(label2);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePickerDate);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxAmount);
            Controls.Add(dataGridViewRecords);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRecords;
        private TextBox textBoxAmount;
        private ComboBox comboBoxType;
        private DateTimePicker dateTimePickerDate;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn 日期;
        private DataGridViewTextBoxColumn 項目;
        private DataGridViewTextBoxColumn 金額;
    }
}

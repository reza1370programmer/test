namespace UserRegisteration
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtMobile = new MaskedTextBox();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(716, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "نام : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(671, 78);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(678, 120);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "شماره تلفن :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(706, 166);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "آدرس :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(383, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(253, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(383, 75);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(253, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(383, 158);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(253, 83);
            txtAddress.TabIndex = 7;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(383, 117);
            txtMobile.Mask = "(+\\98)-\\900- 000-0000";
            txtMobile.Name = "txtMobile";
            txtMobile.RightToLeft = RightToLeft.No;
            txtMobile.Size = new Size(253, 23);
            txtMobile.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(438, 258);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(143, 42);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "درج اطلاعات";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, Mobile, Address });
            dataGridView1.Location = new Point(12, 334);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.Size = new Size(783, 203);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "شناسه";
            Id.Name = "Id";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "نام";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "نام خانوادگی";
            LastName.Name = "LastName";
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            Mobile.DefaultCellStyle = dataGridViewCellStyle2;
            Mobile.HeaderText = "شماره تلفن";
            Mobile.Name = "Mobile";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "آدرس";
            Address.Name = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 301);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 11;
            label5.Text = "جستجو :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 298);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(225, 23);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(587, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 42);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "ویرایش";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(328, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 42);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnInsert);
            Controls.Add(txtMobile);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private MaskedTextBox txtMobile;
        private Button btnInsert;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Address;
        private Label label5;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnDelete;
    }
}

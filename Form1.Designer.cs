namespace GYMMEMBERSHIPMANAGEMENTSYSTEM
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            MemberId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MembershipType = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            ExpiryDate = new DataGridViewTextBoxColumn();
            MembershipStatus = new DataGridViewTextBoxColumn();
            Paymentstatus = new DataGridViewTextBoxColumn();
            Monthlyfee = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button5 = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 22);
            label1.Name = "label1";
            label1.Size = new Size(217, 15);
            label1.TabIndex = 0;
            label1.Text = "Gym Membership Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Member ID :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 138);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Full Name :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 199);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 5;
            label4.Text = "Phone Number :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(267, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 254);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "Email :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(248, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 319);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 9;
            label6.Text = "Membership Type :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 311);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 23);
            comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(130, 378);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 11;
            button1.Text = "Add Member";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(236, 378);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 12;
            button2.Text = "Remove Member";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(365, 378);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MemberId, FullName, PhoneNumber, Email, MembershipType, StartDate, ExpiryDate, MembershipStatus, Paymentstatus, Monthlyfee });
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(-1, 414);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1045, 121);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MemberId
            // 
            MemberId.HeaderText = "Member ID";
            MemberId.Name = "MemberId";
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // MembershipType
            // 
            MembershipType.HeaderText = "Membership Type";
            MembershipType.Name = "MembershipType";
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Start Date";
            StartDate.Name = "StartDate";
            // 
            // ExpiryDate
            // 
            ExpiryDate.HeaderText = "Expiry Date";
            ExpiryDate.Name = "ExpiryDate";
            // 
            // MembershipStatus
            // 
            MembershipStatus.HeaderText = "MembershipStatus";
            MembershipStatus.Name = "MembershipStatus";
            // 
            // Paymentstatus
            // 
            Paymentstatus.HeaderText = "Payment Status";
            Paymentstatus.Name = "Paymentstatus";
            // 
            // Monthlyfee
            // 
            Monthlyfee.HeaderText = "Monthly Fee";
            Monthlyfee.Name = "Monthlyfee";
            // 
            // button4
            // 
            button4.Location = new Point(455, 378);
            button4.Name = "button4";
            button4.Size = new Size(96, 23);
            button4.TabIndex = 15;
            button4.Text = "View Details";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(566, 378);
            button5.Name = "button5";
            button5.Size = new Size(99, 23);
            button5.TabIndex = 16;
            button5.Text = "Edit Member";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Paid,Outstanding" });
            comboBox2.Location = new Point(544, 311);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 319);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 18;
            label7.Text = "Payment Status";
            label7.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(858, 377);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 23);
            textBox5.TabIndex = 19;
            textBox5.Text = "Search By Name or ID";
            // 
            // button6
            // 
            button6.Location = new Point(989, 377);
            button6.Name = "button6";
            button6.Size = new Size(53, 23);
            button6.TabIndex = 20;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(680, 377);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 21;
            button7.Text = "Save";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(767, 377);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 22;
            button8.Text = "load";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 547);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private ComboBox comboBox2;
        private Label label7;
        private DataGridViewTextBoxColumn MemberId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MembershipType;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn ExpiryDate;
        private DataGridViewTextBoxColumn MembershipStatus;
        private DataGridViewTextBoxColumn Paymentstatus;
        private DataGridViewTextBoxColumn Monthlyfee;
        private TextBox textBox5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}

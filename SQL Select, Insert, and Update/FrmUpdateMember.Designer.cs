namespace SQL_Select__Insert__and_Update
{
    partial class FrmUpdateMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProgram = new ComboBox();
            label7 = new Label();
            cbGender = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtMiddleName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            cbStudentId = new ComboBox();
            SuspendLayout();
            // 
            // txtProgram
            // 
            txtProgram.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtProgram.FormattingEnabled = true;
            txtProgram.Items.AddRange(new object[] { "BS Hospitality Management", "BS Tourism Management", "BS Information Technology" });
            txtProgram.Location = new Point(63, 421);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(183, 23);
            txtProgram.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(63, 403);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 28;
            label7.Text = "Program";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(63, 343);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(183, 23);
            cbGender.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(63, 325);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 26;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(63, 472);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 25;
            label5.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMiddleName.Location = new Point(63, 490);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(183, 23);
            txtMiddleName.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(63, 250);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 23;
            label4.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFirstName.Location = new Point(63, 268);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(183, 23);
            txtFirstName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(63, 185);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 21;
            label3.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAge.Location = new Point(63, 203);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(183, 23);
            txtAge.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(63, 109);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 19;
            label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtLastName.Location = new Point(63, 127);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(183, 23);
            txtLastName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(63, 38);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 17;
            label1.Text = "Student ID:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(75, 568);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(114, 32);
            btnConfirm.TabIndex = 30;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // cbStudentId
            // 
            cbStudentId.FormattingEnabled = true;
            cbStudentId.Items.AddRange(new object[] { "BS Hospitality Management", "BS Tourism Management", "BS Information Technology" });
            cbStudentId.Location = new Point(63, 56);
            cbStudentId.Name = "cbStudentId";
            cbStudentId.Size = new Size(183, 23);
            cbStudentId.TabIndex = 31;
            cbStudentId.SelectedIndexChanged += cmbStudentId_SelectedIndexChanged;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 634);
            Controls.Add(cbStudentId);
            Controls.Add(btnConfirm);
            Controls.Add(txtProgram);
            Controls.Add(label7);
            Controls.Add(cbGender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMiddleName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private ComboBox txtProgram;
        private Label label7;
        private ComboBox cbGender;
        private Label label6;
        private Label label5;
        private TextBox txtMiddleName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtAge;
        private Label label2;
        private TextBox txtLastName;
        private Label label1;
        private Button btnConfirm;
        private ComboBox cbStudentId;
    }

}
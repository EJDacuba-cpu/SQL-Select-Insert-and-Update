namespace SQL_Select__Insert__and_Update
{
    partial class FrmClubRegistration
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
            txtStudentID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            txtMiddleName = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            btnRegister = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStudentID.Location = new Point(129, 54);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(171, 23);
            txtStudentID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(129, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(129, 107);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtLastName.Location = new Point(129, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 23);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(129, 196);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAge.Location = new Point(129, 214);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(171, 23);
            txtAge.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(327, 107);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFirstName.Location = new Point(327, 125);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 23);
            txtFirstName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(525, 107);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 10;
            label5.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMiddleName.Location = new Point(525, 125);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(171, 23);
            txtMiddleName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(327, 196);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 11;
            label6.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(327, 214);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(192, 23);
            cmbGender.TabIndex = 13;
            // 
            // cmbProgram
            // 
            cmbProgram.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(525, 54);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(192, 23);
            cmbProgram.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(525, 36);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 14;
            label7.Text = "Program";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 301);
            label8.Name = "label8";
            label8.Size = new Size(127, 17);
            label8.TabIndex = 16;
            label8.Text = "LIst of Club Member";
            label8.Click += label8_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(808, 78);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(127, 42);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(808, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 42);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(823, 422);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(127, 42);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(772, 238);
            dataGridView1.TabIndex = 20;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 571);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(label8);
            Controls.Add(cmbProgram);
            Controls.Add(label7);
            Controls.Add(cmbGender);
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
            Controls.Add(txtStudentID);
            Name = "FrmClubRegistration";
            Text = "Form1";
            Load += FrmClubRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private Label label1;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtFirstName;
        private Label label5;
        private TextBox txtMiddleName;
        private Label label6;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Label label7;
        private Label label8;
        private Button btnRegister;
        private Button btnUpdate;
        private Button btnRefresh;
        private DataGridView dataGridView1;
    }
}

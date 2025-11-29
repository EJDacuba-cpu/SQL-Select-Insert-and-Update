using System.Data;
using System.Numerics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SQL_Select__Insert__and_Update
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;

        private int ID = 0, Age = 0, count = 0;

        private string FirstName, MiddleName, LastName, Gender, Program;

        private long StudentId;



        public FrmClubRegistration()
        {
            InitializeComponent();

            cbGender.Items.AddRange(new string[] { "Male", "Female" });
            cbGender.SelectedIndex = 0;

            txtProgram.Items.AddRange(new string[] {
                "BS Hospitality Management",
                "BS Tourism Management",
                "BS Information Technology" });
            txtProgram.SelectedIndex = 0;
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }

        private void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }
        private int RegistrationID()
        {
            count++;

            ID = count;

            return ID;
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                //=========== Validations ==============
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
     
                if (!int.TryParse(txtAge.Text.Trim(), out int age))
                {
                    MessageBox.Show("Please enter a valid number for Age.");
                    return;
                }
                if (!long.TryParse(txtStudentID.Text.Trim(), out long studentId))
                {
                    MessageBox.Show("Please enter a valid number for Student ID.");
                    return;
                }

                //=========== Validation sa Combobox============
                string gender = cbGender.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }
                string program = txtProgram.SelectedItem?.ToString(); 
                if (string.IsNullOrEmpty(program))
                {
                    MessageBox.Show("Please select a program.");
                    return;
                }


                // =============Para ma Get ang ininput ni User============
                long IDregistration = RegistrationID();

                string firstName = txtFirstName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtLastName.Text;

                bool sumakses = clubRegistrationQuery.RegisterStudent (IDregistration, studentId, firstName, middleName, lastName, age, gender, program);

                if (sumakses)
                {
                    clubRegistrationQuery.DisplayList();
                    dataGridView1.DataSource = clubRegistrationQuery.bindingSource;

                    //para maclear sa next entry
                    txtStudentID.Clear();
                    txtFirstName.Clear();
                    txtMiddleName.Clear();
                    txtLastName.Clear();
                    txtAge.Clear();
                    txtProgram.SelectedIndex = 0;               
                    cbGender.SelectedIndex = 0;
                    MessageBox.Show("Student registered successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to register student.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
 

        }
        
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateForm = new FrmUpdateMember(clubRegistrationQuery);
            updateForm.ShowDialog();
            RefreshListOfClubMembers();
        }
    

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 

        }
        

        private void cmbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}   


























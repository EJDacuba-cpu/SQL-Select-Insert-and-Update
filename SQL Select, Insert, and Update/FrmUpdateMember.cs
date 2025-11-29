using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace SQL_Select__Insert__and_Update
{
    public partial class FrmUpdateMember : Form
    {
        ClubRegistrationQuery clubQuery;

        public FrmUpdateMember(ClubRegistrationQuery query)
        {
            InitializeComponent();
            clubQuery = query;
            LoadStudentIDs();
        }

        private void LoadStudentIDs()
        {
            clubQuery.DisplayList();
            cbStudentId.DataSource = clubQuery.dataTable;
            cbStudentId.DisplayMember = "StudentID";
            cbStudentId.ValueMember = "StudentID";

        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {

        }

        private void cmbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudentId.SelectedValue == null || cbStudentId.SelectedValue is DataRowView)
                return;

            long id = long.Parse(cbStudentId.SelectedValue.ToString());
            DataRow row = clubQuery.dataTable.Select($"StudentID = {id}")[0];
            txtFirstName.Text = row["FirstName"].ToString();
            txtMiddleName.Text = row["MiddleName"].ToString();
            txtLastName.Text = row["LastName"].ToString();
            txtAge.Text = row["Age"].ToString();
            cbGender.Text = row["Gender"].ToString();
            txtProgram.Text = row["Program"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbStudentId.SelectedValue != null)
            {
                long studentID = long.Parse(cbStudentId.SelectedValue.ToString());
                bool success = clubQuery.UpdateStudent(
                    studentID,
                    txtFirstName.Text,
                    txtMiddleName.Text,
                    txtLastName.Text,
                    int.Parse(txtAge.Text),
                    cbGender.Text,
                    txtProgram.Text
                );

                if (success)
                    MessageBox.Show("Record updated successfully!");
                else
                    MessageBox.Show("Failed to update record.");

                this.Close(); 
            }
        }
    }
}
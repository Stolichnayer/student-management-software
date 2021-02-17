using System.Data;
using System.Drawing;
using System.Windows.Forms;
using student_management_system.Controller;

namespace student_management_system.Forms
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
            DoubleBuffered = true;

            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            const string query = "SELECT * FROM students";

            DataSet dataset = DatabaseManager.GetInstance().ExecuteQuery(query);

            //Set DataGridView data source to our dataset
            dataGridViewStudents.DataSource = dataset.Tables[0];

            //Disable buttons if there are no data
            if (dataGridViewStudents.Rows.Count == 0)
            {
                //btnEditStudent.Enabled = false;
                //btnRegisterStudent.Enabled = false;
            }

            totalStudentsLabel.Text = $"Total students: {dataGridViewStudents.Rows.Count}";

            dataGridViewStudents.Columns[0].HeaderText = "Reg. ID";
            dataGridViewStudents.Columns[1].HeaderText = "First name";
            dataGridViewStudents.Columns[2].HeaderText = "Last name";
            dataGridViewStudents.Columns[3].HeaderText = "Email";
            dataGridViewStudents.Columns[4].HeaderText = "Birth date";
            dataGridViewStudents.Columns[5].HeaderText = "Reg. date";
            dataGridViewStudents.Columns[6].HeaderText = "GPA";
        }

        private void dataGridViewStudents_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CustomizeRows();
        }

        private void CustomizeRows()
        {
            dataGridViewStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(153, 153, 255);
            dataGridViewStudents.Font = new Font("Century Gothic", 10, FontStyle.Regular);
        }
    }
}




using UserRegisteration.MyDbContext;

namespace UserRegisteration
{
    public partial class MainForm : Form
    {
        public DataLayer MyDataLayer { get; set; }
        public MainForm()
        {
            InitializeComponent();
            MyDataLayer = new DataLayer();
            ShowDataInGridView();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newStudent = new Student();
                newStudent.FirstName = txtFirstName.Text;
                newStudent.LastName = txtLastName.Text;
                newStudent.Mobile = txtMobile.Text;
                newStudent.Address = txtAddress.Text;
                MyDataLayer.AddStudent(newStudent);
                ShowDataInGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ShowDataInGridView()
        {

            dataGridView1.DataSource = MyDataLayer.ReturnData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var SearchKey = txtSearch.Text;
            var data = MyDataLayer.SearchStudents(SearchKey);
            dataGridView1.DataSource = data;

        }
        int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobile.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = MyDataLayer.GetStudent(id);
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Mobile = txtMobile.Text;
            student.Address = txtAddress.Text;
            MyDataLayer.UpdateStudent(student);
            ShowDataInGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show(" آیا از حذف شخص مطمعن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ds == DialogResult.Yes)
            {
                var student = MyDataLayer.GetStudent(id);
                MyDataLayer.DeleteStudent(student);
                ShowDataInGridView();
            }
            else
                return;
        }
    }
}

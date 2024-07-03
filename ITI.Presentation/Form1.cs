using ITI.Business;
using System.Data;

namespace ITI.Presentation
{
    public partial class Form1 : Form
    {
        StudentService studentService = new StudentService();
        DepartmentService departmentService = new DepartmentService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = studentService.GetAll();

            dgv_students.DataSource = dataTable;

            DataTable depts = departmentService.GetNamesWithIds();

            cb_dept.DataSource = depts;
            cb_dept.DisplayMember = "Name";
            cb_dept.ValueMember = "Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // validation

           int result = studentService.Add(txt_name.Text, (int)nud_age.Value, txt_address.Text, (int)cb_dept.SelectedValue);
    
            if(result > 0)
            {
                MessageBox.Show("Data Added");
            }

            DataTable dataTable = studentService.GetAll();

            dgv_students.DataSource = dataTable;
        }
    }
}

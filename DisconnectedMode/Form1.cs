using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace DisconnectedMode
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();

            string connectionText = "Server=DESKTOP-FANDAQ8;Database=master;Trusted_connection=True;Trust Server Certificate=True";

            con = new SqlConnection(connectionText);
            adapter = new SqlDataAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GettingStudentData();
            nextId = ((int)dt.Rows[dt.Rows.Count - 1]["Id"]) + 1;
            GetDepartments();
        }


        private void GettingStudentData()
        {

            // define select command
            SqlCommand command = new SqlCommand("Select Id, Name, Age, Address, DeptId from student\r\n", con);

            // attach command to adaptor
            adapter.SelectCommand = command;

            // get data
            dt = new DataTable();
            adapter.Fill(dt);

            // present data
            dgv_students.DataSource = dt;

            // data binding => dgv , dt   => Bi Directional
        }

        private void GetDepartments()
        {
            SqlCommand command = new SqlCommand("select Id, Name from Department", con);

            adapter.SelectCommand = command;

            DataTable dt2 = new DataTable();

            adapter.Fill(dt2);

            cb_dept.DataSource = dt2;

            cb_dept.DisplayMember = "Name";
            cb_dept.ValueMember = "Id";

        }

        int nextId = -1;

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["Id"] = nextId++;
            row["Name"] = txt_name.Text;
            row["Age"] = nud_age.Value;
            row["Address"] = txt_address.Text;
            row["DeptId"] = cb_dept.SelectedValue;


            dt.Rows.Add(row);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //foreach(DataRow row in dt.Rows) {
            //    Debug.WriteLine(row.RowState);

            //}

            // define commands

            SqlCommand insertCmd = new SqlCommand("insert into Student values(@name,@age,@address,@dept)", con);
            insertCmd.Parameters.Add("name", SqlDbType.NVarChar, 50, "Name");
            insertCmd.Parameters.Add("age", SqlDbType.Int, 4, "Age");
            insertCmd.Parameters.Add("address", SqlDbType.NVarChar, 50, "Address");
            insertCmd.Parameters.Add("dept", SqlDbType.Int, 4, "DeptId");

            SqlCommand updateCmd = new SqlCommand("update student set name=@name, age=@age,Address = @address where Id = @id", con);
            updateCmd.Parameters.Add("name", SqlDbType.NVarChar, 50, "Name");
            updateCmd.Parameters.Add("age", SqlDbType.Int, 4, "Age");
            updateCmd.Parameters.Add("address", SqlDbType.NVarChar, 50, "Address");
            updateCmd.Parameters.Add("dept", SqlDbType.Int, 4, "DeptId");
            updateCmd.Parameters.Add("id", SqlDbType.Int, 4, "Id");

            SqlCommand deleteCmd = new SqlCommand("delete from student where id = @id", con);
            deleteCmd.Parameters.Add("id", SqlDbType.Int, 4, "Id");


            // attach commands to adaptor

            adapter.InsertCommand = insertCmd;
            adapter.UpdateCommand = updateCmd;
            adapter.DeleteCommand = deleteCmd;

            // SYNCHRONISE
            adapter.Update(dt);


            GettingStudentData();

        }
    }
}

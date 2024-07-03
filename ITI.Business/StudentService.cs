using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.DataAccess;

namespace ITI.Business
{
    public class StudentService
    {
        public DataTable GetAll()
        {
            string commandText = "Select Id, Name, Age, Address, DeptId from student";

            return DbContext.ExecuteQuery(commandText);
        }

        public int Add(string name, int age, string address, int dept)
        {
            string commandText = $"insert into Student values('{name}',{age},'{address}',{dept})";

            return DbContext.ExecuteNonQuery(commandText);
        }
    }
}

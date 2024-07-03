using ITI.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Business
{
    public class DepartmentService
    {
        public DataTable GetNamesWithIds()
        {
            string commandText = "select Id, Name from Department";

            return DbContext.ExecuteQuery(commandText);
        }
    }
}

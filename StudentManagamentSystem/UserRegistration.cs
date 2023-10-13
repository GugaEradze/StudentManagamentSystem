using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagamentSystem
{
    internal class UserRegistration
    {
        DbContext context = new DbContext();
        Score score = new Score();

        public bool CheckUser(string userName)
        {
            DataTable dataTable = score.GetStudentsList(new SqlCommand("SELECT * FROM Users WHERE Username = '" + userName + "'"));
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUser(string userName, string password)
        {
            SqlCommand command = new("INSERT INTO Users(Username, Password) values(@un, @pas)", context.GetConnection());

            command.Parameters.Add("@un", System.Data.SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@pas", System.Data.SqlDbType.VarChar).Value = password;

            context.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                context.CloseConnection();
                return true;
            }
            else
            {
                context.CloseConnection();
                return false;
            }
        }
    }
}

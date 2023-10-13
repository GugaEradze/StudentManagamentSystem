using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace StudentManagamentSystem
{
    internal class Course
    {
        DbContext context = new DbContext();

        public bool InsertCourse(string courseName, int courseHour, string courseDescription)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Courses(CourseName, CourseHour, CourseDescription) VALUES(@cn, @ch, @desc)", context.GetConnection());

            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@ch", System.Data.SqlDbType.Int).Value = courseHour;
            command.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = courseDescription;

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

        public DataTable GetCourseList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Courses", context.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    

    public bool UpdateCourse(int id, string courseName, int courseHour, string courseDescription)
        {
            SqlCommand command = new SqlCommand("UPDATE Courses SET CourseName = @cn, CourseHour = @ch, CourseDescription = @desc WHERE ID = @id", context.GetConnection());

            command.Parameters.Add("id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@ch", System.Data.SqlDbType.Int).Value = courseHour;
            command.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = courseDescription;

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
        public bool DeleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Courses WHERE ID = @id", context.GetConnection());
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
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

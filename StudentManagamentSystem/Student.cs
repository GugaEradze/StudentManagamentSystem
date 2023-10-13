using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace StudentManagamentSystem
{
    internal class Student
    {
        DbContext context = new DbContext();

        public bool InsertStudent(string firstName,  string lastName, DateTime birthDate, string gender, string phone, string address)
        {
            SqlCommand command = new("insert into Students(FirstName, LastName, BirthDate, Gender, Phone, Address) values(@fn, @ln, @bd, @gd, @ph, @adr)", context.GetConnection());

            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@bd", System.Data.SqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@gd", System.Data.SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", System.Data.SqlDbType.Text).Value = address;

            context.OpenConnection();

            if(command.ExecuteNonQuery() == 1)
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

        public bool UpdateStudent(int id, string firstName, string lastName, DateTime birthDate, string gender, string phone, string address)
        {
            SqlCommand command = new("UPDATE Students SET FirstName = @fn, LastName = @ln, BirthDate = @bd, Gender = @gd, Phone = @ph, Address = @adr WHERE ID = @id", context.GetConnection());

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@bd", System.Data.SqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@gd", System.Data.SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", System.Data.SqlDbType.Text).Value = address;

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

        public DataTable GetStudentsList(SqlCommand command)
        {
            command.Connection = context.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable SearchStudentsList(string searchData)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[SchoolManagement].[dbo].[Students] WHERE CONCAT(FirstName, LastName, Address) LIKE '%" + searchData + "%'", context.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        internal bool InsertStudent(string firstName, string lastName, DateTime birthDate, string phone, string adress)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Students WHERE ID = @id", context.GetConnection());
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            context.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                context.CloseConnection() ;
                return true;
            }
            else
            {
                context.CloseConnection();
                return false;
            }
        }

        public string ExecuteCount(string query)
        {
            SqlCommand command = new SqlCommand(query, context.GetConnection());
            context.OpenConnection();
            string count = command.ExecuteScalar().ToString();
            context.CloseConnection();
            return count;
        }

        public string TotalCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Students");
        }

        public string MaleCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM [SchoolManagement].[dbo].[Students] WHERE Gender = 'Male'");
        }

        public string FemaleCount()
        {
            return ExecuteCount("SELECT COUNT(*) FROM [SchoolManagement].[dbo].[Students] WHERE Gender = 'Female'");
        }

        public string GetCourseHour(string courseName)
        {
            return ExecuteCount("SELECT CourseHour FROM [SchoolManagement].[dbo].[Courses] WHERE CourseName = '" + courseName + "'");
        }
    }
}

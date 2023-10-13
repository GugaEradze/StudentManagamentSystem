using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace StudentManagamentSystem
{
    internal class Score
    {
        DbContext context = new DbContext();

        public bool InsertScore(int studentID, string courseName, decimal score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO StudentScores (StudentID, CourseName, Score, Description) VALUES(@stdID, @cn, @sc, @desc)", context.GetConnection());

            command.Parameters.Add("@stdID", System.Data.SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("sc", System.Data.SqlDbType.Decimal).Value = score;
            command.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = description;

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

        public bool CheckScore(int studentID, string courseName)
        {
            DataTable dataTable = GetStudentsList(new SqlCommand("SELECT * FROM StudentScores WHERE StudentID = '"+ studentID +"' AND  CourseName = '"+ courseName +"'"));
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateScore(int studentID, string courseName, decimal score, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE StudentScores SET CourseName = @cn, Score = @sc, Description = @desc WHERE StudentID = @stdID", context.GetConnection());

            command.Parameters.Add("@stdID", System.Data.SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("sc", System.Data.SqlDbType.Decimal).Value = score;
            command.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = description;

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
        public bool DeleteScore(int id, string courseName)
        {
            SqlCommand command = new SqlCommand("DELETE FROM StudentScores WHERE StudentID = @stdID AND CourseName = @cn", context.GetConnection());
            command.Parameters.Add("@stdID", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@cn", System.Data.SqlDbType.VarChar).Value = courseName;
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

        public DataTable SearchScoresList(string searchData)
        {
            SqlCommand command = new SqlCommand("SELECT StudentScores.StudentID, Students.FirstName, Students.LastName, StudentScores.CourseName, StudentScores.Score, StudentScores.Description FROM Students INNER JOIN StudentScores ON StudentScores.StudentID = Students.ID WHERE CONCAT (Students.FirstName, Students.LastName, StudentScores.Score) LIKE '%" + searchData + "%'", context.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}

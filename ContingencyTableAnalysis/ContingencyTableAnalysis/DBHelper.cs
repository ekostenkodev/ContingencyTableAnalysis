using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContingencyTableAnalysis
{
    class DBHelper
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AnalysisDB.mdf;Integrated Security=True;Connect Timeout=30";
        


        public static string[][] GetAnalysisLabels()
        {
            SqlConnection conn;

            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();


            string sql = "Select Label1, Label2, Label3, Label4, Label5, Label6 from AnalysisLabel";

            // Создать объект Command.
            SqlCommand cmd = new SqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            string[][] labels = {
                new string[6],
                new string[6],
                new string[6],
                new string[6],
                new string[6] };

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    int row = 0;

                    while (reader.Read())
                    {
                        labels[row][0] = reader[0].ToString();
                        labels[row][1] = reader.GetString(1);
                        labels[row][2] = reader.GetString(2);
                        labels[row][3] = reader.GetString(3);
                        labels[row][4] = reader.GetString(4);
                        labels[row][5] = reader.GetString(5);

                        row++;
                    }
                }
            }

            conn.Close();


            return labels;


        }

        public static string GetAnalysisName(int index)
        {
            SqlConnection conn;

            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();


            string sql = "Select Name from Analysis WHERE id = "+index;

            // Создать объект Command.
            SqlCommand cmd = new SqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            string name = null;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        name = reader.GetString(0);

                    }
                }
            }

            conn.Close();

            return name;


        }

        public static List<string>[] GetAnalysisParameters(int parameterIndex = -1)
        {

            SqlConnection conn;

            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            List<string>[] parameters;


            

            // todo переделать, тк все держится на индексах
            string sql = "SELECT a.AnalysisID , p.Name as p_Name FROM AnalysisDetails a INNER JOIN Parameters p ON a.ParameterID = p.Id";

            parameters = new List<string>[] {
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>()};

            if (parameterIndex != -1)
            {
                sql += " WHERE a.AnalysisID = " + parameterIndex;
            }

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        parameters[reader.GetInt32(0) - 1].Add(reader.GetString(1));
                    }
                }
            }

            conn.Close();


            return parameters;

        }
        public static Tuple<string,string> GetParameterInfo(string parameterName)
        {
            SqlConnection conn;

            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            string sql = "Select Arguments, Expression from Parameters WHERE Name LIKE N\'" + parameterName + "\' OR Abbreviation LIKE N\'" + parameterName + "\' ";
            // Создать объект Command.
            SqlCommand cmd = new SqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            string arguments = null, expression = null;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        arguments =     reader.GetString(0);
                        expression =    reader.GetString(1);

                    }
                }
            }
            conn.Close();

            return new Tuple<string, string>(arguments, expression);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace CCMM
{
    class GenericObject
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public float Amount { get; set; }
    }

    class DAL
    {
        private static string connectionString = "Data Source=..\\..\\CMMM.DB.sdf";

        /// <summary>
        /// Used to fill DataViewGrids 
        /// </summary>
        /// <param name="query">The SQL query that will fill the DataViewGrid</param>
        /// <returns>A DataTable to fill the grid</returns>
        public static DataTable dtFill(string query)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);

            //Open connection and execute command
            sqlConnection.Open();
            SqlCeDataAdapter sqlAdapter = new SqlCeDataAdapter(query, sqlConnection);

            //Create and fill DataTable
            DataTable dtQuery = new DataTable();
            sqlAdapter.Fill(dtQuery);

            //Close connection
            sqlConnection.Close();
            sqlConnection.Dispose();

            //Returns DataTable
            return dtQuery;
        }

        public static DataTable SearchStudent(List<string> parameters, string accNum = "")
        {
            //Create connection
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);

            //Query to get all students
            string baseQuery = "SELECT Students.Account_Num AS Cuenta, Students.First_Name AS Nombre," +
                "Students.Last_Name AS [Ap. Paterno], Students.Last_Name_2 AS [Ap. Materno]," +
                "Students.[Group] AS Grado, Students.Discount AS Descuento, School_Levels.Title AS Nivel " +
                "FROM Students INNER JOIN School_Levels ON Students.School_Level = School_Levels.SC_ID";

            if (accNum != "")
            {
                baseQuery += " WHERE Students.Account_Num =" + accNum;
            }
            else if(parameters.Count > 0)
            {
                //Add to base query
                baseQuery += " WHERE ";

                //For each parameter, except the last one, add "AND" to the base query
                for (int i = 0; i < parameters.Count; i++)
                {
                    baseQuery += parameters[i];

                    if (parameters.Count > 1 || i < (parameters.Count - 1))
                    {
                        baseQuery += " AND ";
                    }
                }
            }

            DataTable dtQuery = new DataTable();
            SqlCeDataAdapter sqlAdapter = new SqlCeDataAdapter(baseQuery, sqlConnection);
            sqlAdapter.Fill(dtQuery);

            sqlConnection.Close();

            return dtQuery;
        }
    }
}

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

        /// <summary>
        /// Retrieves all information about a specific student
        /// </summary>
        /// <param name="studentAccount">The student's account number</param>
        /// <returns>Array containing each column's value</returns>
        public static List<string> getStudentDetails(Int32 studentAccount)
        {
            //Create List
            List<string> studentDetails = new List<string>();

            //Open connection and create the command 
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            SqlCeCommand sqlCommmand = sqlConnection.CreateCommand();
            sqlCommmand.CommandText = "SELECT * FROM Students WHERE Account_Num = " + studentAccount;

            //Execute the command and save each column into the List<>
            SqlCeDataReader sqlReader = sqlCommmand.ExecuteReader();

            while (sqlReader.Read())
            {
                for (int i = 0; i < sqlReader.FieldCount; i++)
                {
                    studentDetails.Add(sqlReader[i].ToString());
                }
            }

            sqlConnection.Close();

            //Return the List<>
            return studentDetails;
        }

        public static void setWeeksforYear()
        {
            //Create list with 52 or 53 entries for each week of the current year
            //Entries will be like [2XXX] Semana #X Date - Date
            List<string> weekYears = BAL.CreateWeekEntries();

            //Create and open connection
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            SqlCeCommand insertCommand = new SqlCeCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandType = System.Data.CommandType.Text;

            foreach (string week in weekYears)
            {

                //INSERT INTO Conceptos (Title, Base_Amount, Concept_Type) VALUES ('Test', 3000, 'No')
                insertCommand.CommandText = "INSERT INTO Conceptos (Title, Base_Amount, Concept_Type) VALUES ('" + week + "', 400, 'Internado')";
                insertCommand.ExecuteNonQuery();
            }
            
        }

        /// <summary>
        /// Retreive a list<> of available concepts for the selected account
        /// </summary>
        /// <param name="stdGroup">Group of student</param>
        /// <param name="stdLevel">Level of student</param>
        /// <returns></returns>
        public static List<GenericObject> getAvailableConcepts(int stdGroup, int stdLevel)
        {
            List<GenericObject> lstConcept = new List<GenericObject>();
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);

            sqlConnection.Open();
            SqlCeCommand sqlCommand = new SqlCeCommand();
            sqlCommand.CommandText = "SELECT Rel_GL_Concept.FK_Concept_ID, Conceptos.* " +
                "FROM Rel_GL_Concept INNER JOIN " +
                "Conceptos ON Rel_GL_Concept.FK_Concept_ID = Conceptos.ID " +
                "WHERE (REL_GL_Concept.FK_Group_ID = " + stdGroup.ToString() +
                " ) OR (Rel_GL_Concept.FK_Level_ID = " + stdLevel.ToString() + " )";

            sqlCommand.Connection = sqlConnection;

            SqlCeDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                GenericObject gObject = new GenericObject();
                gObject.Name = sqlReader["Title"].ToString(); ;
                gObject.Amount = float.Parse(sqlReader["Base_Amount"].ToString());
                gObject.Value = sqlReader["FK_Concept_ID"].ToString();

                lstConcept.Add(gObject);
            }

            return lstConcept;
        }
    }
}

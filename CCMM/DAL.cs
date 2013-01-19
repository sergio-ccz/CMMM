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

        /// <summary>
        /// Returns a DataTable with information about a student (via search)
        /// </summary>
        /// <param name="parameters">Search Parameters</param>
        /// <param name="accNum">Account number, if declared it will search directly by it</param>
        /// <returns>Datable with student details</returns>
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

        /// <summary>
        /// Inserts records for each week of the current year, will be used every new year.
        /// </summary>
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
        /// <returns>List with objects representign the different concepts</returns>
        public static List<GenericObject> getAvailableConcepts(int stdGroup, int stdLevel)
        {
            //Create list to hold concepts
            List<GenericObject> lstConcept = new List<GenericObject>();
            
            //Create connection, command and open connection. 
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            SqlCeCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            
            //Gets concepts that are available depending on group and level of student
            sqlCommand.CommandText = "SELECT Rel_GL_Concept.FK_Concept_ID, Conceptos.* " +
                "FROM Rel_GL_Concept INNER JOIN " +
                "Conceptos ON Rel_GL_Concept.FK_Concept_ID = Conceptos.ID " +
                "WHERE (REL_GL_Concept.FK_Group_ID = " + stdGroup.ToString() +
                " ) OR (Rel_GL_Concept.FK_Level_ID = " + stdLevel.ToString() + " )";

            SqlCeDataReader sqlReader = sqlCommand.ExecuteReader();

            //Create objects for each concept and fill List<>
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

        /// <summary>
        /// Checks if student is enrolled in after-school programs
        /// </summary>
        /// <param name="stdID">Student Id</param>
        /// <returns>True/False depending on after-school program enrollment</returns>
        public static bool getAfterSchool(Int32 stdID)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            string baseQuery = "SELECT After_School FROM Students WHERE Account_Num =";
            baseQuery += stdID;

            return false;
        }

        /// <summary>
        /// Gets the list of concepts from the after-school programs
        /// </summary>
        /// <returns>List with each concept (id, title & amount)</returns>
        public static List<GenericObject> getAfterSchoolConcepts()
        {
            //Create list, connection and open connection.
            List<GenericObject> lstConcept = new List<GenericObject>();
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            SqlCeCommand qCommand = new SqlCeCommand();
            //Get all concepts that are type "Internado"
            qCommand.CommandText = "SELECT ID, Title, Base_Amount FROM Conceptos WHERE (Concept_Type = 'Internado')" +
                "ORDER BY ID";

            qCommand.Connection = sqlConnection;
            SqlCeDataReader sqlReader = qCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                GenericObject gObject = new GenericObject();
                gObject.Name = sqlReader["Title"].ToString(); ;
                gObject.Amount = float.Parse(sqlReader["Base_Amount"].ToString());
                gObject.Value = sqlReader["ID"].ToString();

                lstConcept.Add(gObject);
            }

            sqlConnection.Close();

            return lstConcept;
        }

        /// <summary>
        /// Creates new record that represents payment of a student
        /// </summary>
        /// <param name="nPayment"></param>
        public static void InsertPayment(newPayment nPayment)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            SqlCeCommand newPaymentCommand = new SqlCeCommand("INSERT INTO Payment (Folio, Amount, Date, Completed, Student_ID, Concept_ID) " +
                "VALUES (@pFolio, @pAmount, @pDate, @pComplete, @pStudentID, @pConceptID)", sqlConnection);

            newPaymentCommand.Parameters.AddWithValue("@pFolio", nPayment.paymentFolio);
            newPaymentCommand.Parameters.AddWithValue("@pAmount", nPayment.payedAmount);
            newPaymentCommand.Parameters.AddWithValue("@pDate", nPayment.paymentDate);
            newPaymentCommand.Parameters.AddWithValue("@pComplete", nPayment.paymentComplete);
            newPaymentCommand.Parameters.AddWithValue("@pStudentID", nPayment.studentID);
            newPaymentCommand.Parameters.AddWithValue("@pConceptID", nPayment.conceptID);

            newPaymentCommand.CommandType = System.Data.CommandType.Text;

            try
            {
                newPaymentCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public static bool checkFolio(string pFolio)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            int folioCount = 0;
            sqlConnection.Open();

            SqlCeCommand checkFolioCommand = sqlConnection.CreateCommand();
            checkFolioCommand.CommandText = "SELECT COUNT(Folio) FROM Payment WHERE Folio = @pFolio";

            checkFolioCommand.Parameters.AddWithValue("@pFolio", pFolio);

            folioCount = (Int32) checkFolioCommand.ExecuteScalar();

            sqlConnection.Close();

            if (folioCount != 0)
                return true;
            else
                return false;
        }

        public static DataTable getPaymentsByStudent(double studentID, DateTime? startDate, DateTime? endDate, bool dateFilter = false)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);

            sqlConnection.Open();
            SqlCeCommand sqlCommand = new SqlCeCommand();
            sqlCommand.CommandText = "SELECT Payment.Folio, Payment.Amount AS Cantidad, " +
                "Payment.Date AS Fecha, Payment.Completed AS Completado, Conceptos.Title AS " +
                "Concepto FROM Payment INNER JOIN Conceptos ON Payment.Concept_ID = Conceptos.ID " +
                "WHERE (Payment.Student_ID = " + studentID.ToString() + " )";

            if (dateFilter)
            {
                sqlCommand.CommandText += " AND (Date > CONVERT(DATETIME, '" + startDate.ToString() + "', 102)) AND (Date < CONVERT(DATETIME, '" + endDate.ToString() + "', 102))";
            }

            // Create a new data adapter based on the specified query.
            SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(sqlCommand.CommandText, sqlConnection);

            // Create a command builder to generate SQL update, insert, and 
            // delete commands based on selectCommand. These are used to 
            // update the database.
            SqlCeCommandBuilder commandBuilder = new SqlCeCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable payTables = new DataTable();
            payTables.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(payTables);

            return payTables;
        }

        public static string updateStudentRecord(List<string> studentDetails, string currentAccNum)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            int group = Int16.Parse(studentDetails[4]);

            string response = "";

            //AccNum, fName, lastname, lastname2, grade, discount
            SqlCeCommand updateCommand = new SqlCeCommand("UPDATE Students SET Account_Num = @AccN, First_Name = @fName, Last_Name = @lName, Last_Name_2 = @lName2, [Group] = @gNum WHERE Account_Num = @currentStu", sqlConnection);

            updateCommand.Parameters.AddWithValue("@AccN", int.Parse(studentDetails[0]));
            updateCommand.Parameters.AddWithValue("@fName", studentDetails[1]);
            updateCommand.Parameters.AddWithValue("@lName", studentDetails[2]);
            updateCommand.Parameters.AddWithValue("@lName2", studentDetails[3]);
            updateCommand.Parameters.AddWithValue("@gNum", Int16.Parse(studentDetails[4]));
            updateCommand.Parameters.AddWithValue("@disc", Int16.Parse(studentDetails[5]));
            updateCommand.Parameters.AddWithValue("@currentStu", currentAccNum);

            updateCommand.CommandType = System.Data.CommandType.Text;

            try
            {
                updateCommand.ExecuteNonQuery();
                response = "OK";
            }
            catch (Exception e)
            {
                response = e.ToString();
            }

            sqlConnection.Close();
            sqlConnection.Dispose();

            return response;
        }
    }
}

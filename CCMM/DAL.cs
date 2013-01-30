using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace CCMM
{


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

                    if (parameters[i] != parameters.Last())
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
        /// <returns>Student object [infoStudent]</returns>
        public static infoStudent getStudentDetails(Int32 studentAccount)
        {
            //Create student object
            infoStudent studentDetails = new infoStudent();

            //Create connection, command and open connection. 
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            SqlCeCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();

            //Gets concepts that are available depending on group and level of student
            sqlCommand.CommandText = "SELECT * FROM Students WHERE Account_Num = " + studentAccount;
            SqlCeDataReader sqlReader = sqlCommand.ExecuteReader();

            //Get values from columns, add to student object
            while (sqlReader.Read())
            {
                studentDetails.studentID = Int32.Parse(sqlReader["Account_Num"].ToString());
                studentDetails.studentFistName = sqlReader["First_Name"].ToString();
                studentDetails.studentLastName = sqlReader["Last_Name"].ToString();
                studentDetails.studentLastName2 = sqlReader["Last_Name_2"].ToString();
                studentDetails.studentGroup = int.Parse(sqlReader["Group"].ToString());
                studentDetails.studentLevel = int.Parse(sqlReader["School_Level"].ToString());
                studentDetails.paymentDiscount = int.Parse(sqlReader["Discount"].ToString());
                studentDetails.paymentType = sqlReader["Pay_Type"].ToString();
                if (sqlReader["After_School"].ToString() == "1")
                    studentDetails.studentAfterSchool = true;
                else
                    studentDetails.studentAfterSchool = false;
            }

            if (studentDetails.studentID == 0)
                return null;

            return studentDetails;
        }



        /// <summary>
        /// Inserts records for each week of the current year, will be used every new year.
        /// </summary>
        public static void setWeeksforYear()
        {
            //Create list with 52 or 53 entries for each week of the current year
            //Entries will be like [2XXX] Semana #X Date - Date
            List<string[]> weekYears = BAL.CreateWeekEntries();

            //Create and open connection
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            SqlCeCommand insertCommand = new SqlCeCommand();
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandType = System.Data.CommandType.Text;

            foreach (string[] week in weekYears)
            {

                //INSERT INTO Conceptos (Title, Base_Amount, Concept_Type) VALUES ('Test', 3000, 'No')
                insertCommand.CommandText = "INSERT INTO Conceptos (Title, Base_Amount, Concept_Type, Limit_Date) VALUES ('" + week[0] + "', 400, 'Internado', '" + week[1] + "')";
                insertCommand.ExecuteNonQuery();
            }
            
        }

        /// <summary>
        /// Retreive a list<> of available concepts for the selected account
        /// </summary>
        /// <param name="stdGroup">Group of student</param>
        /// <param name="stdLevel">Level of student</param>
        /// <returns>List with objects representign the different concepts</returns>
        public static List<infoConcept> getAvailableConcepts(int stdGroup, int stdLevel)
        {
            //Create list to hold concepts
            List<infoConcept> lstConcept = new List<infoConcept>();
            
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
                infoConcept gObject = new infoConcept();
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
        public static List<infoConcept> getAfterSchoolConcepts()
        {
            //Create list, connection and open connection.
            List<infoConcept> lstConcept = new List<infoConcept>();
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            SqlCeCommand qCommand = new SqlCeCommand();
            //Get all concepts that are type "Internado"
            qCommand.CommandText = "SELECT ID, Title, Base_Amount, Limit_Date FROM Conceptos WHERE (Concept_Type = 'Internado')" +
                "ORDER BY ID";

            qCommand.Connection = sqlConnection;
            SqlCeDataReader sqlReader = qCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                infoConcept gObject = new infoConcept();
                gObject.Name = sqlReader["Title"].ToString(); ;
                gObject.Amount = float.Parse(sqlReader["Base_Amount"].ToString());
                gObject.Value = sqlReader["ID"].ToString();
                gObject.LimitDate = DateTime.Parse(sqlReader["Limit_Date"].ToString());

                lstConcept.Add(gObject);
            }

            sqlConnection.Close();

            return lstConcept;
        }

        /// <summary>
        /// Creates new record that represents payment of a student
        /// </summary>
        /// <param name="nPayment"></param>
        public static void InsertPayment(infoPayment nPayment)
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

        public static DataTable getPaymentsByDate(DateTime startDate, DateTime? endDate)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);

            sqlConnection.Open();
            SqlCeCommand sqlCommand = new SqlCeCommand();
            sqlCommand.CommandText = "SELECT Payment.Folio, Payment.Amount AS Cantidad, " +
                "Payment.Date AS Fecha, Payment.Completed AS Completado, Conceptos.Title AS " +
                "Concepto FROM Payment INNER JOIN Conceptos ON Payment.Concept_ID = Conceptos.ID ";

            if (endDate != null)
            {
                sqlCommand.CommandText += " WHERE (Date > CONVERT(DATETIME, '" + startDate.ToShortDateString() + "', 102)) AND (Date < CONVERT(DATETIME, '" + endDate.Value.ToShortDateString() + "', 102))";
            }
            else
            {
                sqlCommand.CommandText += " WHERE (Date > CONVERT(DATETIME, '" + startDate.ToShortDateString() + "', 102))";
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

        public static List<int> getPayedConceptList(Int32 studentID)
        {
            List<int> payedConcepts = new List<int>();

            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            SqlCeCommand sqlCommand = new SqlCeCommand();
            sqlCommand.CommandText = "SELECT Concept_ID FROM Payment WHERE Student_ID = @stID";

            sqlCommand.Parameters.AddWithValue("@stID", studentID);
            sqlCommand.Connection = sqlConnection;
            SqlCeDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                payedConcepts.Add(int.Parse(sqlReader["Concept_ID"].ToString()));
            }

            sqlConnection.Close();

            return payedConcepts;
        }


        public static string updateStudentRecord(infoStudent editedStudent, Int32 currentAccNum)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            string response = "";

            //test
            editedStudent.paymentType = "Normal";

            //AccNum, fName, lastname, lastname2, grade, discount
            SqlCeCommand updateCommand = new SqlCeCommand("UPDATE Students SET Account_Num = @AccN, First_Name = @fName, Last_Name = @lName, Last_Name_2 = @lName2," +
                "[Group] = @gNum, School_Level = @sLevel, Discount = @disc, Pay_Type = @payType, After_School = @inASch WHERE Account_Num = @currentStu", sqlConnection);

            updateCommand.Parameters.AddWithValue("@AccN", editedStudent.studentID);
            updateCommand.Parameters.AddWithValue("@fName", editedStudent.studentFistName);
            updateCommand.Parameters.AddWithValue("@lName", editedStudent.studentLastName);
            updateCommand.Parameters.AddWithValue("@lName2", editedStudent.studentLastName2);
            updateCommand.Parameters.AddWithValue("@gNum", editedStudent.studentGroup);
            updateCommand.Parameters.AddWithValue("@sLevel", editedStudent.studentLevel);
            updateCommand.Parameters.AddWithValue("@disc", editedStudent.paymentDiscount);
            updateCommand.Parameters.AddWithValue("@payType", editedStudent.paymentType);

            if (editedStudent.studentAfterSchool)
                updateCommand.Parameters.AddWithValue("@inASch", 1);
            else
                updateCommand.Parameters.AddWithValue("@inASch", 0);
            
            updateCommand.Parameters.AddWithValue("@currentStu", currentAccNum);

            updateCommand.CommandType = System.Data.CommandType.Text;

            try
            {
                updateCommand.ExecuteNonQuery();
                response = "OK";
            }
            catch (Exception e)
            {
                throw e;
            }

            sqlConnection.Close();
            sqlConnection.Dispose();

            return response;
        }

        public static void newStudentRecord(infoStudent newStudent)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            sqlConnection.Open();

            //AccNum, fName, lastname, lastname2, grade, discount
            SqlCeCommand newStudentCommand = new SqlCeCommand("INSERT INTO Students VALUES (@accNum, @fistName, @lastName, @lastName2, @stdGroup, @stdLevel, @stdDiscount, @accType, @afterSchool)", sqlConnection);
            newStudentCommand.CommandType = System.Data.CommandType.Text;

            newStudentCommand.Parameters.AddWithValue("@accNum", newStudent.studentID);
            newStudentCommand.Parameters.AddWithValue("@fistName", newStudent.studentFistName);
            newStudentCommand.Parameters.AddWithValue("@lastName", newStudent.studentLastName);
            newStudentCommand.Parameters.AddWithValue("@lastName2", newStudent.studentLastName2);
            newStudentCommand.Parameters.AddWithValue("@stdGroup", newStudent.studentGroup);
            newStudentCommand.Parameters.AddWithValue("@stdLevel", newStudent.studentLevel);
            newStudentCommand.Parameters.AddWithValue("@stdDiscount", newStudent.paymentDiscount);
            newStudentCommand.Parameters.AddWithValue("@accType", newStudent.paymentType);
            
            if(newStudent.studentAfterSchool)
                newStudentCommand.Parameters.AddWithValue("@afterSchool", 1);
            else
                newStudentCommand.Parameters.AddWithValue("@afterSchool", 0);
            

            try
            {
                newStudentCommand.ExecuteNonQuery();
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

        /// <summary>
        /// Retreive a list<> of available concepts for the selected account
        /// </summary>
        /// <param name="stdGroup">Group of student</param>
        /// <param name="stdLevel">Level of student</param>
        /// <returns>List with objects representign the different concepts</returns>
        public static List<infoConcept> getExpiredSchoolConcepts(int stdGroup, int stdLevel, Int32 studentID)
        {
            //Create list to hold concepts
            List<infoConcept> lstConcept = new List<infoConcept>();
            List<infoConcept> lstExpiredConcepts = new List<infoConcept>();

            //Create connection, command and open connection. 
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            SqlCeCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();

            //Gets concepts that have expired that are avaible to the student depending on group and level
            sqlCommand.CommandText = "SELECT Rel_GL_Concept.FK_Concept_ID, Conceptos.ID, Conceptos.Title, Conceptos.Base_Amount," +
                " Conceptos.Concept_Type, Conceptos.Limit_Date FROM Rel_GL_Concept INNER JOIN Conceptos " + 
                " ON Rel_GL_Concept.FK_Concept_ID = Conceptos.ID WHERE (Rel_GL_Concept.FK_Group_ID = " + stdGroup +") AND" +
                " (Conceptos.Limit_Date < CONVERT(DATETIME, '" + DateTime.Now.ToShortDateString() + "', 102)) OR" + 
                " (Rel_GL_Concept.FK_Level_ID = " + stdLevel +") AND (Conceptos.Limit_Date < CONVERT(DATETIME, '" + DateTime.Now.ToShortDateString() +"', 102))";

            SqlCeDataReader sqlReader = sqlCommand.ExecuteReader();

            //Create objects for each concept and fill List<>
            while (sqlReader.Read())
            {
                infoConcept gObject = new infoConcept();
                gObject.Name = sqlReader["Title"].ToString(); ;
                gObject.Amount = float.Parse(sqlReader["Base_Amount"].ToString());
                gObject.Value = sqlReader["FK_Concept_ID"].ToString();
                gObject.LimitDate = DateTime.Parse(sqlReader["Limit_Date"].ToString());
                gObject.Type = sqlReader["Concept_Type"].ToString();

                lstConcept.Add(gObject);
            }

            //Expired concepts for student: lstConcept;

            //Get payments made by student
            List<int> payedConcepts = getPayedConceptList(studentID);
            bool payed = false;

            foreach (infoConcept aConcept in lstConcept)
            {
                if (aConcept.Type == "School")
                {
                    foreach (int pIDConcept in payedConcepts)
                    {
                        if (pIDConcept == int.Parse(aConcept.Value))
                        {
                            payed = true;
                        }
                    }

                    if (!payed)
                        lstExpiredConcepts.Add(aConcept);
                }
            }

            return lstExpiredConcepts;
        }

        public static List<infoConcept> getExpiredASConcepts(Int32 studentID)
        {
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            List<infoConcept> afConcepts = getAfterSchoolConcepts();
            List<int> payedConcepts = getPayedConceptList(studentID);
            List<infoConcept> expiredConcepts = new List<infoConcept>();

            bool payed = false;

            foreach (infoConcept afCon in afConcepts)
            {
                if (afCon.LimitDate < DateTime.Now)
                {
                    payed = false;

                    foreach (int conceptID in payedConcepts)
                    {
                        if (conceptID == int.Parse(afCon.Value))
                        {
                            payed = true;
                        }
                    }

                    if (!payed)
                        expiredConcepts.Add(afCon);
                }
            }

            return expiredConcepts;
            
        }
    }
}

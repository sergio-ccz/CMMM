using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CCMM
{
    class BAL
    {
        public static List<string[]> CreateWeekEntries()
        {
            List<string[]> yearWeeks2 = new List<string[]>();
            List<string> yearWeeks = new List<string>();
            string format = "MMM-ddd-d";

            for (int i = 1; i < 53; i++)
            {
                yearWeeks.Clear();
                DateTime[] tempWeek = WeekDays(DateTime.Now.Year, i);
                yearWeeks.Add("[" + DateTime.Now.Year + "]" + " #" + i + " " + tempWeek[0].ToString(format) + " -> " + tempWeek[6].ToString(format));
                yearWeeks.Add(tempWeek[6].ToShortDateString());
                yearWeeks2.Add(yearWeeks.ToArray());
            }

            return yearWeeks2;
        }

        public static string MoneyFormat = "$#,##0.00;-$#,##0.00;Zero";

        private static DateTime[] WeekDays(int Year, int WeekNumber)
        {
            DateTime start = new DateTime(Year, 1, 4);
            start = start.AddDays(-((int)start.DayOfWeek));
            start = start.AddDays(7 * (WeekNumber - 1));
            return Enumerable.Range(1, 7).Select(num => start.AddDays(num)).ToArray();
        }

        public static void CreateNewPayment(List<string> paymentDetails)
        {
            //Create payment object and assign values
            infoPayment nPayment = new infoPayment();

            nPayment.paymentFolio = paymentDetails[0];
            nPayment.payedAmount = double.Parse(paymentDetails[1]);
            nPayment.paymentDate = DateTime.Parse(paymentDetails[2]);
            nPayment.paymentComplete = bool.Parse(paymentDetails[3]);
            nPayment.studentID = Int32.Parse(paymentDetails[4]);
            nPayment.conceptID = int.Parse(paymentDetails[5]);

            DAL.InsertPayment(nPayment); 
        }

        /// <summary>
        /// Calculates on which school level is a determined group
        /// </summary>
        /// <param name="stdGrade"></param>
        /// <returns></returns>
        public static int getLevelfromGrade(int stdGrade)
        {
            //A student the 99 group is after-school only
            if (stdGrade >= 20)
            {
                //After-school only
                return 5;
            }

            if (stdGrade <= 6)
            {
                //Primaria
                return 1;
            }

            if (stdGrade >= 7 && stdGrade <= 9)
            {
                //Secundaria
                return 2;
            }

            if (stdGrade >= 10 && stdGrade <= 12)
            {
                //Preparatoria
                return 3;
            }

            if (stdGrade >= 13 && stdGrade <= 21)
            {
                //Licenciatura
                return 4;
            }


            //After school only if a problem arises
            return 99;
        }
        
        public static int getLevelbyName(string levelName)
        {
            int schoolLevel = 1;

            switch (levelName)
            {
                case "Primaria":
                    schoolLevel = 1;
                    break;

                case "Secundaria":
                    schoolLevel = 2;
                    break;

                case "Preparatoria":
                    schoolLevel = 3;
                    break;

                case "Universidad":
                    schoolLevel = 4;
                    break;

                case "Medio Internado":
                    schoolLevel = 5;
                    break;
            }

            return schoolLevel;
        }

        public static List<infoConcept> getAvailableConcepts(Int32 studentID, string conceptType, bool showAll)
        {
            //Get student information
            infoStudent payingStudent = DAL.getStudentDetails(studentID);
            List<infoConcept> availableConcepts = new List<infoConcept>();
            List<int> payedConcepts = new List<int>();
            //Get available concepts for student

            if (conceptType == "School")
                availableConcepts = DAL.getAvailableConcepts(payingStudent.studentGroup, payingStudent.studentLevel);
            else
                availableConcepts = DAL.getAfterSchoolConcepts();

            if (showAll)
                return availableConcepts;

            //Get payments made by student
            payedConcepts = DAL.getPayedConceptList(studentID);
            
            //Parse results and create a list of concepts already paid
            for (int i = 0; i < availableConcepts.Count; i++)
            {
                foreach (int pConcept in payedConcepts)
                {
                    if (int.Parse(availableConcepts[i].Value) == pConcept)
                    {
                        //Delete concepts that have already been payed
                        availableConcepts.RemoveAt(i);
                        break;
                    }
                }
            }

            return availableConcepts;
        }

        public static DataTable getExpiredSchoolConcepts(int stdGroup, int stdLevel, Int32 studentID)
        {
            List<infoConcept> expiredConcepts = DAL.getExpiredSchoolConcepts(stdGroup, stdLevel, studentID);

            DataTable table = new DataTable();
            table.Columns.Add("Concepto", typeof(string));
            table.Columns.Add("Fecha limite", typeof(DateTime));
            table.Columns.Add("Monto a Pagar", typeof(double));

            foreach (infoConcept expConcept in expiredConcepts)
            {
                table.Rows.Add(expConcept.Name, expConcept.LimitDate, expConcept.Amount);
            }

            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        public static int getGradeLevel(int level, int grade)
        {
            int[] levelValues = new int[5] { 0, 6, 9, 12, 20 };

            return grade - levelValues[level - 1];
        }

        public static List<string[]> getExpiredConceptsAll(int conceptType)
        {
            List<string[]> expiredPayments = new List<string[]>();
            List<string> tempList = new List<string>();

            //Get all students
            List<infoStudent> allStudents = DAL.GetAllStudents();

            //Break if no students were found
            if (allStudents.Count == 0)
                return null;

            //Go trough each student
            foreach (var student in allStudents)
            {
                //Get all school concepts
                if (conceptType == 1)
                {
                    if (student.studentLevel == 5)
                        continue;
                }
                else
                {
                    if (student.studentLevel != 5)
                        continue;
                }

                //Get expired concepts for that student
                List<infoConcept> expiredByStudent = DAL.getExpiredSchoolConcepts(student.studentGroup, student.studentLevel, student.studentID);

                //If no expired concepts were found
                if (expiredByStudent.Count == 0)
                    continue;

                //Check each expired concept for the student
                foreach (var expiredConcept in expiredByStudent)
                {
                    tempList = new List<string>();
                    //sid, slvl, concept  name, concept amount
                    tempList.Add(student.studentID.ToString());
                    tempList.Add(student.studentLevel.ToString());
                    tempList.Add(expiredConcept.Name);
                    tempList.Add(expiredConcept.Amount.ToString());

                    expiredPayments.Add(tempList.ToArray());
                }
            }

            return expiredPayments;
        }

        
    }

            
}

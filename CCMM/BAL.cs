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

        public static List<string[]> CreateStudentReport(infoStudent selectedStudent, DataTable paymentTable)
        {
            List<string[]> reportData = new List<string[]>();
            List<string> tempList = new List<string>();


            //Folio, Cantidad, Fecha, Completado, Concepto

            foreach(DataRow payRow in paymentTable.Rows)
            {
                tempList = new List<string>();

                tempList.Add(selectedStudent.studentID.ToString());
                tempList.Add(selectedStudent.studentLastName + " " + selectedStudent.studentLastName2 + " " + selectedStudent.studentFistName);
                foreach (var item in payRow.ItemArray)
                {
                    tempList.Add(item.ToString());
                }

                reportData.Add(tempList.ToArray());
            }

            if (reportData.Count > 0)
                return reportData;

            return null;
        }

        public static void ModifyDiferidoConcepts(List<infoConcept> conceptList)
        {
            double vacationAmount = 0;
            int vacationCount = 0;

            for (int i = 0; i < conceptList.Count; i++)
            {
                if (conceptList[i].Name.Contains("Vacaci"))
                {
                    vacationAmount += conceptList[i].Amount;
                    vacationCount++;
                    conceptList.Remove(conceptList[i]);
                }
            }


            foreach (infoConcept concept in conceptList)
            {
                
            }

            vacationAmount = vacationAmount / (conceptList.Count + vacationCount);

            foreach (infoConcept con in conceptList)
            {
                con.Amount = con.Amount + float.Parse(vacationAmount.ToString());
            }
        }

        public static void DeleteAccount(infoStudent toDelete)
        {
            DAL.DeletePayments(toDelete.studentID);
            DAL.DeleteAccount(toDelete.studentID);
        }

        public static List<infoConcept> GetUnpayedConcepts(infoStudent selectedStudent)
        {
            List<infoConcept> studentConcepts = DAL.getAvailableConcepts(selectedStudent.studentGroup, selectedStudent.studentLevel);
            List<int> payedConcepts = DAL.getPayedConceptList(selectedStudent.studentID);

            for (int i = 0; i < studentConcepts.Count; i++)
            {
                foreach (int concept in payedConcepts)
                {
                    if (int.Parse(studentConcepts[i].Value) == concept)
                    {
                        studentConcepts.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            return studentConcepts;
        }

        public static double CalculateOvercharge(infoStudent selectedStudent)
        {
            List<infoConcept> expiredConcepts = DAL.getExpiredSchoolConcepts(selectedStudent.studentGroup, selectedStudent.studentLevel, selectedStudent.studentID);
            List<double> overCharges = DAL.OverchargeAmounts();
            double totalCharge = 0.0;

            if (expiredConcepts.Count > 0)
            {
                foreach (infoConcept concept in expiredConcepts)
                {
                    if (concept.Type == "Mensualidad")
                    {
                        int afterDays = (DateTime.Now - concept.LimitDate).Days;

                        if (afterDays > overCharges[0])
                            totalCharge = overCharges[1];

                        if (afterDays > overCharges[2])
                            totalCharge = overCharges[3];

                        if (afterDays > overCharges[4])
                            totalCharge = overCharges[5];
                    }
                }
            }

            //check if at least one unpayed concept exists
            //check if it's mensualidad
            //add value depening on database to all until unpayed concept is payed (none exist)
            return totalCharge;
        }
    }    
}

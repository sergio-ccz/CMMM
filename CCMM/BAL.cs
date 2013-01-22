using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CCMM
{
    class BAL
    {
        public static List<string> CreateWeekEntries()
        {
            List<string> yearWeeks = new List<string>();

            for (int i = 1; i < 53; i++)
            {
                DateTime[] tempWeek = WeekDays(DateTime.Now.Year, i);
                yearWeeks.Add("[" + DateTime.Now.Year + "]" + "Semana #" + i + " " + tempWeek[0].ToShortDateString() + " - " + tempWeek[6].ToShortDateString());
            }

            return yearWeeks;
        }

        private static DateTime[] WeekDays(int Year, int WeekNumber)
        {
            DateTime start = new DateTime(Year, 1, 4);
            start = start.AddDays(-((int)start.DayOfWeek));
            start = start.AddDays(7 * (WeekNumber - 1));
            return Enumerable.Range(0, 7).Select(num => start.AddDays(num)).ToArray();
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
            if (stdGrade == 99)
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCMM
{
    class newPayment
    {
        public string paymentFolio { get; set; }
        public double payedAmount { get; set; }
        public DateTime paymentDate { get; set; }
        public bool paymentComplete { get; set; }
        public string paymentComments { get; set; }
        public Int32 studentID { get; set; }
        public int conceptID { get; set; }
    }

    class infoStudent
    {
        public Int32 studentID { get; set; }
        public string studentFistName { get; set; }
        public string studentLastName { get; set; }
        public string studentLastName2 { get; set; }
        public int studentGroup { get; set; }
        public int studentLevel { get; set; }
        public int paymentDiscount { get; set; }
        public string paymentType { get; set; }
        public bool studentAfterSchool { get; set; }
    }

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
            //paymentDetails.Add(txtbPaymentFolio.Text);
            //paymentDetails.Add(txtbPaymentAmount.Text);
            //paymentDetails.Add(datePaymentDate.Value.ToString());
            //paymentDetails.Add(cbPaymentComplete.Checked.ToString());
            //paymentDetails.Add(selectedStudent[0]);
            //paymentDetails.Add(cbPaymentConcept.SelectedValue.ToString());

            newPayment nPayment = new newPayment();
            nPayment.paymentFolio = paymentDetails[0];
            nPayment.payedAmount = double.Parse(paymentDetails[1]);
            nPayment.paymentDate = DateTime.Parse(paymentDetails[2]);
            nPayment.paymentComplete = bool.Parse(paymentDetails[3]);
            nPayment.studentID = Int32.Parse(paymentDetails[4]);
            nPayment.conceptID = int.Parse(paymentDetails[5]);

            DAL.InsertPayment(nPayment); 
        }
    }
}

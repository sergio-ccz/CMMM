using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCMM
{
    class infoPayment
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

    class infoConcept
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public float Amount { get; set; }
    }

    class ProgramObjects
    {
    }
}

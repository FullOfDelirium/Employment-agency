using System;

namespace Praktika
{
    public class Applicant
    {
        public int ApplicantCode { get; set; }

        public string FIO { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string PhoneNum { get; set; }

        Applicant(int ApplicantCode, string FIO, string Gender, int Age, string PhoneNum)
        {
            this.ApplicantCode = ApplicantCode;
            this.FIO = FIO;
            this.Gender = Gender;
            this.Age = Age;
            this.PhoneNum = PhoneNum;
        }
    }
}

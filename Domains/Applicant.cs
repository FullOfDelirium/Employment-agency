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

        public Applicant(int applicantCode, string FIO, string gender, int age, string phoneNum)
        {
            ApplicantCode = ApplicantCode;
            FIO = FIO;
            Gender = gender;
            Age = age;
            PhoneNum = phoneNum;
        }
    }
}

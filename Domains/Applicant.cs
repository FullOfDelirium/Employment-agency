using System;
using Praktika.repository;

namespace Praktika.Domains
{
    public class Applicant: IStIdentifier
    {
        public int ID { get; set; }
        public int ApplicantCode { get; set; }

        public string FIO { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string PhoneNum { get; set; }

        public Applicant(int applicantCode, string fIO, string gender, int age, string phoneNum)
        {
            ApplicantCode = applicantCode;
            FIO = fIO;
            Gender = gender;
            Age = age;
            PhoneNum = phoneNum;
        }
    }
}

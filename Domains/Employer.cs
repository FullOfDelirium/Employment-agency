using System;

namespace Praktika
{
    public class Employer
    {
        
        public int EmployerCode { get; set; }

        public string Organization { get; set; }

        public string PhoneNum { get; set; }

        public Employer(int emlopyerCode, string organization, string phoneNum)
        {
            EmployerCode = employerCode;
            Organization = organization;
            PhoneNum = phoneNum;
        }
    }
}

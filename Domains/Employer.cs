using System;

namespace Praktika
{
    public class Employer
    {
        
        public int EmployerCode { get; set; }

        public string Organization { get; set; }

        public string PhoneNum { get; set; }

        Employer(int EmlopyerCode, string Organization, string PhoneNum)
        {
            this.EmployerCode = EmployerCode;
            this.Organization = Organization;
            this.PhoneNum = PhoneNum;
        }
    }
}

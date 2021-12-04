using System;
using Praktika.repository;

namespace Praktika.Domains
{
    public class Employer: IStIdentifier
    {
        public int ID { get; set; }
        public int EmployerCode { get; set; }

        public string Organization { get; set; }

        public string PhoneNum { get; set; }

        public Employer(int emplopyerCode, string organization, string phoneNum)
        {
            EmployerCode = emplopyerCode;
            Organization = organization;
            PhoneNum = phoneNum;
        }
    }
}

using System;

namespace Praktika
{
    public class EmpoyerResponse
    {

        public int RStatusCode { get; set; }

        public int EmployerCode { get; set; }

        public string RStatus { get; set; }

        public EmployerResponse(int rStatusCode, int emlopyerCode, string rStatus)
        {
            EmployerCode = employerCode;
            RStatusCode = rStatusCode;
            RStatus = rStatus;
        }
    }
}

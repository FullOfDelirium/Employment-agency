using System;
using Praktika.repository;

namespace Praktika.Domains
{
    public class EmployerResponse: StID
    {

        public int RStatusCode { get; set; }

        public int EmployerCode { get; set; }

        public string RStatus { get; set; }

        public EmployerResponse(int rStatusCode, int emplopyerCode, string rStatus)
        {
            EmployerCode = emplopyerCode;
            RStatusCode = rStatusCode;
            RStatus = rStatus;
        }
    }
}

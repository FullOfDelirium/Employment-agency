using System;

namespace Praktika
{
    public class EmpoyerResponse
    {

        public int RStatusCode { get; set; }

        public int EmployerCode { get; set; }

        public string RStatus { get; set; }

        EmployerResponse(int RStatusCode, int EmlopyerCode, string RStatus)
        {
            this.EmployerCode = EmployerCode;
            this.RStatusCode = RStatusCode;
            this.RStatus = RStatus;
        }
    }
}

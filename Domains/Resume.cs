using System;
using System.Collections.Generic;
using Praktika.repository;

namespace Praktika.Domains
{
    public class Resume: IStIdentifier
    {
        public int ID { get; set; }
        public int ResumeNum { get; set; }

        public int ApplicantCode { get; set; }

        public int WExperience { get; set; }

        public string Education { get; set; }

        public string City { get; set; }

        public int VStatusCode { get; set; }

        public int RStatusCode { get; set; }

       public Resume(int resumeNum, int applicantCode, int wExperience, string education, string city, int vStatusCode, int rStatusCode)
        {
            ResumeNum = resumeNum;
            ApplicantCode = applicantCode;
            WExperience = wExperience;
            Education = education;
            City = city;
            VStatusCode = vStatusCode;
            RStatusCode = rStatusCode;
        }
    }
}

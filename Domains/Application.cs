using System;
using Praktika.repository;

namespace Praktika.Domains
{
    public class Application: WithID
    {
        public int ApplicationNum { get; set; }

        public int ApplicantCode { get; set; }

        public int WExperience { get; set; }

        public string Education { get; set; }

        public string City { get; set; }

        public int VacancyNum { get; set; }

        public int RStatusCode { get; set; }

        public Applicantion(int applicantionCode, int applicantCode, int wExperience, string education, string city, int vacancyNum, int rStatusCode)
        {
            ApplicantionCode = applicantionCode;
            ApplicantCode = applicantCode;
            WExperience = wExperience;
            Education = education;
            City = city;
            VacancyNum = vacancyNum;
            RStatusCode = rStatusCode;
        }

    }
}

using System;

namespace Praktika
{
    public class Application
    {
        public int ApplicationNum { get; set; }

        public int ApplicantCode { get; set; }

        public int WExperience { get; set; }

        public string Education { get; set; }

        public string City { get; set; }

        public int VacancyNum { get; set; }

        public int RStatusCode { get; set; }

        Applicantion(int ApplicantionCode, int ApplicantCode, int WExperience, string Education, string City, int VacancyNum, int RStatusCode)
        {
            this.ApplicantionCode = ApplicantionCode;
            this.ApplicantCode = ApplicantCode;
            this.WExperience = WExperience;
            this.Education = Education;
            this.City = City;
            this.VacancyNum = VacancyNum;
            this.RStatusCode = RStatusCode;
        }

    }
}

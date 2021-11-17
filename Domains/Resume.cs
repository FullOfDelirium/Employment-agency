using System;

namespace Praktika
{
    public class Resume
    {
        public int ResumeNum { get; set; }

        public int ApplicantCode { get; set; }

        public int WExperience { get; set; }

        public string Education { get; set; }

        public string City { get; set; }

        public int VStatusCode { get; set; }

        public int RStatusCode { get; set; }

       Resume(int ResumeNum, int ApplicantCode, int WExperience, string Education, string City, int VStatusCode, int RStatusCode)
        {
            this.ResumeNum =ResumeNum;
            this.ApplicantCode = ApplicantCode;
            this.WExperience = WExperience;
            this.Education = Education;
            this.City = City;
            this.VStatusCode = VStatusCode;
            this.RStatusCode = RStatusCode;
        }
    }
}

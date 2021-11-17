using System;

namespace Praktika
{
    public class Vacancy
    {

        public int VacancyNum { get; set; }

        public int EmployerCode { get; set; }

        public string Post { get; set; }

        public string Salary { get; set; }

        public string KindOfWork { get; set; }

        public string Schelude { get; set; }

        public string Post { get; set; }

        public string RequiredExperience { get; set; }

        public string RequiredEducation { get; set; }

        public string City { get; set; }

        public int VStatusCode { get; set; }

        Vacancy(int VacancyNum, int EmployerCode, string Post, string Salary, string KindOfWork, 
            string Schelude, string Post, string RequiredExperience, string RequiredEducation, string City, int VStatusCode)
        {
            this.VacancyNum = VacancyNum;
            this.EmployerCode = EmployerCode;
            this.Post = Post;
            this.Salary = Salary;
            this.KindOfWork = KindOfWork;
            this.Schelude =Schelude;
            this.Post = Post;
            this.RequiredExperience = RequiredExperience;
            this.RequiredEducation = RequiredEducation;
            this.City = City;
            this.VStatusCode = VStatusCode;
        }
    }
}

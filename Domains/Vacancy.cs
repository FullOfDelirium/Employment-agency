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

        public Vacancy(int vacancyNum, int employerCode, string post, string salary, string kindOfWork, 
            string schelude, string post, string requiredExperience, string requiredEducation, string city, int vStatusCode)
        {
            VacancyNum = vacancyNum;
            EmployerCode = employerCode;
            Post = post;
            Salary = salary;
            KindOfWork = kindOfWork;
            Schelude = schelude;
            Post = post;
            RequiredExperience = requiredExperience;
            RequiredEducation = requiredEducation;
            City = city;
            VStatusCode = vStatusCode;
        }
    }
}

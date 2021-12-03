using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika.Domains;

namespace Praktika.repository
{
    public class Storages
    {
        public static Storage<Applicant> ApplicantStorage { get; } = new();
        public static Storage<Application> ApplicationStorage { get; } = new();
        public static Storage<Employer> EmployerStorage { get; } = new();
        public static Storage<EmployerResponse> EmployerResponseStorage { get; } = new();
        public static Storage<Moderator> ModeratorStorage { get; } = new();
        public static Storage<Resume> ResumeStorage { get; } = new();
        public static Storage<Vacancy> VacancyStorage { get; } = new();
        public static Storage<VerificationStatus> VerificationStatusStorage { get; } = new();
    }
}

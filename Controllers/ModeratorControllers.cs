using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Moderator")]
    public class ModertatorController : ControllerBase
    {
        [HttpGet("ViewResume")]
        public string ViewResume(string str)
        {
            return str;// просмотр резюме
        }

        [HttpGet("ViewVacancies")]
        public string Viewvacancies(string str)
        {
            return str;// просмотр вакансий
        }

        [HttpPost("RejectVacancy")]
        public string Rejectvacancy(string str)
        {
            return str;// забраковать вакансию
        }

        [HttpPost("AcceptVacancy")]
        public string Acceptapplication(string str)
        {
            return str;// одобрить вакансию
        }
    }
}

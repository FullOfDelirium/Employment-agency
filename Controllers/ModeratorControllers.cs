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
        [HttpGet("Viewresume")]
        public string Viewresume(string str)
        {
            return str;// просмотр резюме
        }

        [HttpGet("Viewvacancies")]
        public string Viewvacancies(string str)
        {
            return str;// просмотр вакансий
        }

        [HttpPost("Rejectvacancy")]
        public string Rejectvacancy(string str)
        {
            return str;// забраковать вакансию
        }

        [HttpPost("Acceptvacancy")]
        public string Acceptapplication(string str)
        {
            return str;// одобрить вакансию
        }
    }
}

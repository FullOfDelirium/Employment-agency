using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Applicant")]
    public class ApplicantController : ControllerBase
    {
        [HttpPost("Createresume")]
        public string Createresume(string str)
        {
            return str;// создать резюме
        }

        [HttpGet("Viewvacancies")]
        public string Viewvacancies(string str)
        {
            return str;// просмотр вакансий
        }

        [HttpPost("Sendarequest")]
        public string Sendarequest(string str)
        {
            return str;// отправление заявки
        }

        [HttpGet("Viewresponse")]
        public string Viewresponse(string str)
        {
            return str;// просмотреть ответ
        }
    }
}

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
        [HttpPost("CreateResume")]
        public string CreateResume(string str)
        {
            return str;// создать резюме
        }

        [HttpGet("ViewVacancies")]
        public string ViewVacancies(string str)
        {
            return str;// просмотр вакансий
        }

        [HttpPost("SendRequest")]
        public string SendRequest(string str)
        {
            return str;// отправление заявки
        }

        [HttpGet("ViewResponse")]
        public string ViewResponse(string str)
        {
            return str;// просмотреть ответ
        }

        [HttpPost]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
        }

        [HttpPut]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}

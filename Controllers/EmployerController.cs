using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Employer")]
    public class EmployerController : ControllerBase
    {
        [HttpPost("CreateVacancies")]
        public string Createvacancies(string str)
        {
            return str;// создать вакансии
        }

        [HttpGet("ViewResume")]
        public string Viewresume(string str)
        {
            return str;// просмотр резюме
        }

        [HttpGet("ViewVequest")]
        public string Viewrequest(string str)
        {
            return str;// просмотр заявки
        }

        [HttpPost("RejectApplication")]
        public string Rejecttheapplication(string str)
        {
            return str;// отклонить заявку
        }

        [HttpPost("AcceptApplication")]
        public string Acceptapplication(string str)
        {
            return str;// принять заявку
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

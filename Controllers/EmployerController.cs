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
        [HttpPost("Createvacancies")]
        public string Createvacancies(string str)
        {
            return str;// создать вакансии
        }

        [HttpGet("Viewresume")]
        public string Viewresume(string str)
        {
            return str;// просмотр резюме
        }

        [HttpGet("Viewrequest")]
        public string Viewrequest(string str)
        {
            return str;// просмотр заявки
        }

        [HttpPost("Rejecttheapplication")]
        public string Rejecttheapplication(string str)
        {
            return str;// отклонить заявку
        }

        [HttpPost("Acceptapplication")]
        public string Acceptapplication(string str)
        {
            return str;// принять заявку
        }
    }
}

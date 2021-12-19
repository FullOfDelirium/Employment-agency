using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Praktika.Domains;
using Praktika.repository;

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
        public bool Create(Employer employer)
        {
            return Storages.EmployerStorage.Create(employer);
        }

        [HttpGet]
        public Employer Read(int ID)
        {
            return Storages.EmployerStorage.Read(ID);
        }

        [HttpPut]
        public Employer Update(int ID, Employer employer)
        {
            return Storages.EmployerStorage.Update(ID, employer);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.EmployerStorage.Delete(ID);
        }

        [HttpPost("SaveToStorage")]
        public void SaveToStorage()
        {
            Storages.EmployerStorage.SaveToStorage();
        }

        [HttpGet("LoadFromStorage")]
        public void LoadFromStorage()
        {
            Storages.EmployerStorage.LoadFromStorage();
        }
    }
}

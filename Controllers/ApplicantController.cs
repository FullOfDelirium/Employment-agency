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
        public bool Create(Applicant applicant)
        {
            return Storages.ApplicantStorage.Create(applicant);
        }

        [HttpGet]
        public Applicant Read(int ID)
        {
            return Storages.ApplicantStorage.Read(ID);
        }

        [HttpPut]
        public Applicant Update(Applicant applicant)
        {
            return Storages.ApplicantStorage.Update(applicant);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.ApplicantStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.ApplicantStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.ApplicantStorage.ReadFromXMLFile();
        }
    }
}

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
    [Route("/Vacancy")]
    public class VacancyController : ControllerBase
    {
        [HttpPost]
        public bool Create(Vacancy vacancy)
        {
            return Storages.VacancyStorage.Create(vacancy);
        }

        [HttpGet]
        public Vacancy Read(int ID)
        {
            return Storages.VacancyStorage.Read(ID);
        }

        [HttpPut]
        public Vacancy Update(Vacancy vacancy)
        {
            return Storages.VacancyStorage.Update(vacancy);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.VacancyStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.VacancyStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.VacancyStorage.ReadFromXMLFile();
        }
    }
}

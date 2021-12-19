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
        public Vacancy Update(int ID, Vacancy vacancy)
        {
            return Storages.VacancyStorage.Update(ID, vacancy);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.VacancyStorage.Delete(ID);
        }

        [HttpPost("SaveToStorage")]
        public void SaveToStorage()
        {
            Storages.VacancyStorage.SaveToStorage();
        }

        [HttpGet("LoadFromStorage")]
        public void LoadFromStorage()
        {
            Storages.VacancyStorage.LoadFromStorage();
        }
    }
}

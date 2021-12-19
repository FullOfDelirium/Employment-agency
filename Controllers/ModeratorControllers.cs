﻿using System;
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

        [HttpPost]
        public bool Create(Moderator moderator)
        {
            return Storages.ModeratorStorage.Create(moderator);
        }

        [HttpGet]
        public Moderator Read(int ID)
        {
            return Storages.ModeratorStorage.Read(ID);
        }

        [HttpPut]
        public Moderator Update(int ID, Moderator moderator)
        {
            return Storages.ModeratorStorage.Update(ID, moderator);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.ModeratorStorage.Delete(ID);
        }

        [HttpPost("SaveToStorage")]
        public void SaveToStorage()
        {
            Storages.ModeratorStorage.SaveToStorage();
        }

        [HttpGet("LoadFromStorage")]
        public void LoadFromStorage()
        {
            Storages.ModeratorStorage.LoadFromStorage();
        }
    }
}

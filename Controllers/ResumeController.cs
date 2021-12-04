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
    [Route("/Resume")]
    public class ResumeController : ControllerBase
    {
        [HttpPost]
        public bool Create(Resume resume)
        {
            return Storages.ResumeStorage.Create(resume);
        }

        [HttpGet]
        public Resume Read(int ID)
        {
            return Storages.ResumeStorage.Read(ID);
        }

        [HttpPut]
        public Resume Update(Resume resume)
        {
            return Storages.ResumeStorage.Update(resume);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.ResumeStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.ResumeStorage.SaveFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.ResumeStorage.ReadFile();
        }
    }
}

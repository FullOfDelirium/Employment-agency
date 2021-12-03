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
    [Route("/Request")]
    public class ApplicationController : ControllerBase
    {
        [HttpPost]
        public bool Create(Application application)
        {
            return Storages.ApplicationStorage.Create(application);
        }

        [HttpGet]
        public Application Read(int ID)
        {
            return Storages.ApplicationStorage.Read(ID);
        }

        [HttpPut]
        public Application Update(Application application)
        {
            return Storages.ApplicationStorage.Update(application);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.ApplicationStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.ApplicationStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.ApplicationStorage.ReadFromXMLFile();
        }
    }
}

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
    [Route("/ResponseRequest")]
    public class EmployerResponseController : ControllerBase
    {
        [HttpPost]
        public bool Create(EmployerResponse employerResponse)
        {
            return Storages.EmployerResponseStorage.Create(employerResponse);
        }

        [HttpGet]
        public EmployerResponse Read(int ID)
        {
            return Storages.EmployerResponseStorage.Read(ID);
        }

        [HttpPut]
        public EmployerResponse Update(int ID, EmployerResponse employerResponse)
        {
            return Storages.EmployerResponseStorage.Update(ID, employerResponse);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.EmployerResponseStorage.Delete(ID);
        }

        [HttpPost("SaveToStorage")]
        public void SaveToStorage()
        {
            Storages.EmployerResponseStorage.SaveToStorage();
        }

        [HttpGet("LoadFromStorage")]
        public void LoadFromStorage()
        {
            Storages.EmployerResponseStorage.LoadFromStorage();
        }
    }
}

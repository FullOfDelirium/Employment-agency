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
    [Route("/VerificationStatus")]
    public class VerificationStatusController : ControllerBase
    {
        [HttpPost]
        public bool Create(VerificationStatus verificationStatus)
        {
            return Storages.VerificationStatusStorage.Create(verificationStatus);
        }

        [HttpGet]
        public VerificationStatus Read(int ID)
        {
            return Storages.VerificationStatusStorage.Read(ID);
        }

        [HttpPut]
        public VerificationStatus Update(int ID, VerificationStatus verificationStatus)
        {
            return Storages.VerificationStatusStorage.Update(ID, verificationStatus);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.VerificationStatusStorage.Delete(ID);
        }

        [HttpPost("SaveToStorage")]
        public void SaveToStorage()
        {
            Storages.VerificationStatusStorage.SaveToStorage();
        }

        [HttpGet("LoadFromStorage")]
        public void LoadFromStorage()
        {
            Storages.VerificationStatusStorage.LoadFromStorage();
        }
    }
}

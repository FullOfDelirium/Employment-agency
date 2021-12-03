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
        public VerificationStatus Update(VerificationStatus verificationStatus)
        {
            return Storages.VerificationStatusStorage.Update(verificationStatus);
        }

        [HttpDelete]
        public bool Delete(int ID)
        {
            return Storages.VerificationStatusStorage.Delete(ID);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.VerificationStatusStorage.SaveToXMLFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.VerificationStatusStorage.ReadFromXMLFile();
        }
    }
}

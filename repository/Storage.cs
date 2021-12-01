using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Praktika.Domains;

namespace Praktika.repository
{
    public class StID
    {
        public int ID { get; set; }
    }

    public class Storages
    {
        public static Storage<Applicant> ApplicantStorage { get; } = new Storage<Applicant>();
        public static Storage<Application> ApplicationStorage { get; } = new Storage<Application>();
        public static Storage<Employer> EmployerStorage { get; } = new Storage<Employer>();
        public static Storage<EmployerResponse> EmployerResponseStorage { get; } = new Storage<EmployerResponse>();
        public static Storage<Moderator> ModeratorStorage { get; } = new Storage<Moderator>();
        public static Storage<Resume> ResumeStorage { get; } = new Storage<Resume>();
        public static Storage<Vacancy> VacancyStorage { get; } = new Storage<Vacancy>();
        public static Storage<VerificationStatus> VerificationStatusStorage { get; } = new Storage<VerificationStatus>();
    }

    public class Storage<St> where St : StID
    {
        private static string path = typeof(St).Name + ".xml";
        private List<St> storage = new List<St>();

        public Storage() { }

        public void ReadFromXMLFile()
        {
            if (File.Exists(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<St>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                    storage = (List<St>)xs.Deserialize(fs);
            }
        }

        public void SaveToXMLFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<St>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
                xs.Serialize(fs, storage);
        }

        public bool Create(St obj)
        {
            if (storage.Where(t => t.ID == obj.ID).Count() != 0)
                return false;
            storage.Add(obj);
            return true;
        }

        public St Read(int ID)
        {
            if (storage.Where(t => t.ID == ID).Count() != 0)
                return storage.Where(t => t.ID == ID).First();
            return null;
        }

        public St Update(St obj)
        {
            int index = storage.FindIndex(t => t.ID == obj.ID);
            if (index == -1)
                Create(obj);
            else
                storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID)
        {
            return storage.RemoveAll(t => t.ID == objID) != 0;
        }
    }
}

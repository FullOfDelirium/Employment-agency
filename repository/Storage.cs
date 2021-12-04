using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Praktika.Domains;

namespace Praktika.repository
{
    public class Storage<TIdentifier> where TIdentifier : IIdentifier
    {
        private static readonly string Path = typeof(TIdentifier).Name + "storage.xml";
        private List<TIdentifier> storage = new();


        public Storage() { }

        public void ReadFile()
        {
            if (!File.Exists(Path)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(Path, FileMode.Open);
            storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public void SaveFile()
        {
            if (!File.Exists(Path)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(Path, FileMode.Open);
            storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public bool Create(TIdentifier obj)
        {
            if (storage.Any(t => t.ID == obj.ID))
                return false;
            storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int ID)
        {
            return storage.FirstOrDefault(t => t.ID == ID);
        }

        public TIdentifier Update(TIdentifier obj)
        {
            var index = storage.FindIndex(t => t.ID == obj.ID);
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

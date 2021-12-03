using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Praktika.Domains;

namespace Praktika.repository
{
    public interface IIdentifier
    {
        public int ID { get; set; }
    }
}

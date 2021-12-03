using System;
using Praktika.repository;

namespace Praktika.Domains
{
    public class Moderator: IIdentifier
    {
        public int ID { get; set; }
        public int ModeratorCode { get; set; }

        public string FIO { get; set; }

        public string PhoneNum { get; set; }

        public Moderator(int moderatorCode, string fIO, string phoneNum)
        {
            ModeratorCode = moderatorCode;
            FIO = fIO;
            PhoneNum = phoneNum;
        }
    }
}

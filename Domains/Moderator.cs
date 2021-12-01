using System;

namespace Praktika
{
    public class Moderator
    {
        
        public int ModeratorCode { get; set; }

        public string FIO { get; set; }

        public string PhoneNum { get; set; }

        public Moderator(int moderatorCode, string FIO, string phoneNum)
        {
            ModeratorCode = moderatorCode;
            FIO = FIO;
            PhoneNum = phoneNum;
        }
    }
}

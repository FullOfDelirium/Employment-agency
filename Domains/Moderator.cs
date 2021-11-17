using System;

namespace Praktika
{
    public class Moderator
    {
        
        public int ModeratorCode { get; set; }

        public string FIO { get; set; }

        public string PhoneNum { get; set; }

        Moderator(int ModeratorCode, string FIO, string PhoneNum)
        {
            this.ModeratorCode = ModeratorCode;
            this.FIO = FIO;
            this.PhoneNum = PhoneNum;
        }
    }
}

using System;

namespace Praktika
{
    public class VerificationStatus
    {

        public int VStatusCode { get; set; }

        public int ModeratorCode { get; set; }

        public string Verdict { get; set; }

        VerificationStatus(int VStatusCode, int ModeratorCode, string Verdict)
        {
            this.ModeratorCode = ModeratorCode;
            this.VStatusCode = VStatusCode;
            this.Verdict = Verdict;
        }
    }
}

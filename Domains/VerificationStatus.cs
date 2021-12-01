using System;
using Praktika.repository;

namespace Praktika.Domains
{
    public class VerificationStatus: WithID
    {

        public int VStatusCode { get; set; }

        public int ModeratorCode { get; set; }

        public string Verdict { get; set; }

        public VerificationStatus(int vStatusCode, int moderatorCode, string verdict)
        {
            ModeratorCode = moderatorCode;
            VStatusCode = vStatusCode;
            Verdict = verdict;
        }
    }
}

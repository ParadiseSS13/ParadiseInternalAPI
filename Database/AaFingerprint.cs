using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class AaFingerprint
    {
        public int Id { get; set; }
        public string Ckey { get; set; }
        public string Fingerprint { get; set; }
        public DateTime Date { get; set; }
    }
}

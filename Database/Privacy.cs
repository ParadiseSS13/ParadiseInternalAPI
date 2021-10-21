using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Privacy
    {
        public string Ckey { get; set; }
        public DateTime Datetime { get; set; }
        public ulong Consent { get; set; }
    }
}

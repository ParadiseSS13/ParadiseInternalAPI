using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Watch
    {
        public string Ckey { get; set; }
        public string Reason { get; set; }
        public DateTime Timestamp { get; set; }
        public string Adminckey { get; set; }
        public string LastEditor { get; set; }
        public string Edits { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Memo
    {
        public string Ckey { get; set; }
        public string Memotext { get; set; }
        public DateTime Timestamp { get; set; }
        public string LastEditor { get; set; }
        public string Edits { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class PlaytimeHistory
    {
        public string Ckey { get; set; }
        public DateTime Date { get; set; }
        public short TimeLiving { get; set; }
        public short TimeGhost { get; set; }
    }
}

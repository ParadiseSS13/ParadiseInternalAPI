using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Ckey { get; set; }
        public string Notetext { get; set; }
        public DateTime Timestamp { get; set; }
        public int? RoundId { get; set; }
        public string Adminckey { get; set; }
        public string LastEditor { get; set; }
        public string Edits { get; set; }
        public string Server { get; set; }
        public uint? CrewPlaytime { get; set; }
        public byte? Automated { get; set; }
    }
}

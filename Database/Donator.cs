using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Donator
    {
        public string PatreonName { get; set; }
        public int? Tier { get; set; }
        public string Ckey { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Active { get; set; }
    }
}

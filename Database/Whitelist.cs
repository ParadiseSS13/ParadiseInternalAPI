using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Whitelist
    {
        public int Id { get; set; }
        public string Ckey { get; set; }
        public string Job { get; set; }
        public string Species { get; set; }
    }
}

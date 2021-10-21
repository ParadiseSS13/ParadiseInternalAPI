using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Ipintel
    {
        public uint Ip { get; set; }
        public DateTime Date { get; set; }
        public double Intel { get; set; }
    }
}

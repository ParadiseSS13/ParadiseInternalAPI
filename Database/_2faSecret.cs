using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class _2faSecret
    {
        public string Ckey { get; set; }
        public string Secret { get; set; }
        public DateTime DateSetup { get; set; }
        public DateTime? LastTime { get; set; }
    }
}

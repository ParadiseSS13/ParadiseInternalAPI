﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class LegacyPopulation
    {
        public int Id { get; set; }
        public int? Playercount { get; set; }
        public int? Admincount { get; set; }
        public string ServerId { get; set; }
        public DateTime Time { get; set; }
    }
}

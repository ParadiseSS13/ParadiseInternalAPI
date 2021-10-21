using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Ckey { get; set; }
        public string AdminRank { get; set; }
        public int Level { get; set; }
        public int Flags { get; set; }
    }
}

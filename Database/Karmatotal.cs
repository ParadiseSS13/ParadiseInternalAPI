using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Karmatotal
    {
        public int Id { get; set; }
        public string Byondkey { get; set; }
        public int Karma { get; set; }
        public int Karmaspent { get; set; }
    }
}

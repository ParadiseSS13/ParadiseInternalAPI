using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Changelog
    {
        public int Id { get; set; }
        public int PrNumber { get; set; }
        public DateTime DateMerged { get; set; }
        public string Author { get; set; }
        public string ClType { get; set; }
        public string ClEntry { get; set; }
    }
}

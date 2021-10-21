using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Library
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string Ckey { get; set; }
        public int Flagged { get; set; }
    }
}

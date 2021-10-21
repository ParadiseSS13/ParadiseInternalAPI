using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Death
    {
        public int Id { get; set; }
        public string Pod { get; set; }
        public string Coord { get; set; }
        public DateTime Tod { get; set; }
        public string ServerId { get; set; }
        public string Job { get; set; }
        public string Special { get; set; }
        public string Name { get; set; }
        public string Byondkey { get; set; }
        public string Laname { get; set; }
        public string Lakey { get; set; }
        public string Gender { get; set; }
        public int Bruteloss { get; set; }
        public int Brainloss { get; set; }
        public int Fireloss { get; set; }
        public int Oxyloss { get; set; }
    }
}

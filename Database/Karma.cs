using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Karma
    {
        public int Id { get; set; }
        public string Spendername { get; set; }
        public string Spenderkey { get; set; }
        public string Receivername { get; set; }
        public string Receiverkey { get; set; }
        public string Receiverrole { get; set; }
        public string Receiverspecial { get; set; }
        public bool? Isnegative { get; set; }
        public string Spenderip { get; set; }
        public string ServerId { get; set; }
        public DateTime Time { get; set; }
    }
}

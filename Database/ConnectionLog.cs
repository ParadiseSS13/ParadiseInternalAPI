using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class ConnectionLog
    {
        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public string Ckey { get; set; }
        public string Ip { get; set; }
        public string Computerid { get; set; }
        public string ServerId { get; set; }
        public string Result { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class AdminLog
    {
        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public string Adminckey { get; set; }
        public string Adminip { get; set; }
        public string Log { get; set; }
    }
}

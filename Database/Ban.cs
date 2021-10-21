using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Ban
    {
        public int Id { get; set; }
        public DateTime Bantime { get; set; }
        public int? BanRoundId { get; set; }
        public string Serverip { get; set; }
        public string ServerId { get; set; }
        public string Bantype { get; set; }
        public string Reason { get; set; }
        public string Job { get; set; }
        public int Duration { get; set; }
        public int? Rounds { get; set; }
        public DateTime ExpirationTime { get; set; }
        public string Ckey { get; set; }
        public string Computerid { get; set; }
        public string Ip { get; set; }
        public string ACkey { get; set; }
        public string AComputerid { get; set; }
        public string AIp { get; set; }
        public string Who { get; set; }
        public string Adminwho { get; set; }
        public string Edits { get; set; }
        public bool? Unbanned { get; set; }
        public DateTime? UnbannedDatetime { get; set; }
        public int? UnbannedRoundId { get; set; }
        public string UnbannedCkey { get; set; }
        public string UnbannedComputerid { get; set; }
        public string UnbannedIp { get; set; }
    }
}

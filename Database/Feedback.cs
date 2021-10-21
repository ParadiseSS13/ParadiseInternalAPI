using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Feedback
    {
        public uint Id { get; set; }
        public DateTime Datetime { get; set; }
        public int RoundId { get; set; }
        public string KeyName { get; set; }
        public string KeyType { get; set; }
        public byte Version { get; set; }
        public string Json { get; set; }
    }
}

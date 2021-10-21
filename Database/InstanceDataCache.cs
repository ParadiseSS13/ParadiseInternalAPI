using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class InstanceDataCache
    {
        public string ServerId { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}

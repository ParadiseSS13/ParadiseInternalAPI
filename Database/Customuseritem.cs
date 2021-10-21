using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Customuseritem
    {
        public int Id { get; set; }
        public string CuiCkey { get; set; }
        public string CuiRealName { get; set; }
        public string CuiPath { get; set; }
        public string CuiItemName { get; set; }
        public string CuiDescription { get; set; }
        public string CuiReason { get; set; }
        public string CuiPropAdjust { get; set; }
        public string CuiJobMask { get; set; }
    }
}

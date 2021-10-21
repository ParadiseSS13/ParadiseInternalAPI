using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class PaiSafe
    {
        public int Id { get; set; }
        public string Ckey { get; set; }
        public string PaiName { get; set; }
        public string Description { get; set; }
        public string PreferredRole { get; set; }
        public string OocComments { get; set; }
    }
}

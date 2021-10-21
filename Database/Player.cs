using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Player
    {
        public int Id { get; set; }
        public string Ckey { get; set; }
        public DateTime Firstseen { get; set; }
        public DateTime Lastseen { get; set; }
        public string Ip { get; set; }
        public string Computerid { get; set; }
        public string Lastadminrank { get; set; }
        public string Ooccolor { get; set; }
        public string UiStyle { get; set; }
        public string UiStyleColor { get; set; }
        public short? UiStyleAlpha { get; set; }
        public string BeRole { get; set; }
        public short? DefaultSlot { get; set; }
        public int? Toggles { get; set; }
        public int? Toggles2 { get; set; }
        public int? Sound { get; set; }
        public string VolumeMixer { get; set; }
        public string Lastchangelog { get; set; }
        public string Exp { get; set; }
        public short? Clientfps { get; set; }
        public short? Atklog { get; set; }
        public long? Fuid { get; set; }
        public short? Fupdate { get; set; }
        public bool? Parallax { get; set; }
        public DateTime? ByondDate { get; set; }
        public string _2faStatus { get; set; }
    }
}

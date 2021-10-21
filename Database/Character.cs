using System;
using System.Collections.Generic;

#nullable disable

namespace ParadiseInternalAPI.Database
{
    public partial class Character
    {
        public int Id { get; set; }
        public string Ckey { get; set; }
        public int Slot { get; set; }
        public string OocNotes { get; set; }
        public string RealName { get; set; }
        public bool NameIsAlwaysRandom { get; set; }
        public string Gender { get; set; }
        public short Age { get; set; }
        public string Species { get; set; }
        public string Language { get; set; }
        public string HairColour { get; set; }
        public string SecondaryHairColour { get; set; }
        public string FacialHairColour { get; set; }
        public string SecondaryFacialHairColour { get; set; }
        public short SkinTone { get; set; }
        public string SkinColour { get; set; }
        public string MarkingColours { get; set; }
        public string HeadAccessoryColour { get; set; }
        public string HairStyleName { get; set; }
        public string FacialStyleName { get; set; }
        public string MarkingStyles { get; set; }
        public string HeadAccessoryStyleName { get; set; }
        public string AltHeadName { get; set; }
        public string EyeColour { get; set; }
        public string Underwear { get; set; }
        public string Undershirt { get; set; }
        public string Backbag { get; set; }
        public string BType { get; set; }
        public short AlternateOption { get; set; }
        public int JobSupportHigh { get; set; }
        public int JobSupportMed { get; set; }
        public int JobSupportLow { get; set; }
        public int JobMedsciHigh { get; set; }
        public int JobMedsciMed { get; set; }
        public int JobMedsciLow { get; set; }
        public int JobEngsecHigh { get; set; }
        public int JobEngsecMed { get; set; }
        public int JobEngsecLow { get; set; }
        public int JobKarmaHigh { get; set; }
        public int JobKarmaMed { get; set; }
        public int JobKarmaLow { get; set; }
        public string FlavorText { get; set; }
        public string MedRecord { get; set; }
        public string SecRecord { get; set; }
        public string GenRecord { get; set; }
        public int Disabilities { get; set; }
        public string PlayerAltTitles { get; set; }
        public string OrganData { get; set; }
        public string RlimbData { get; set; }
        public string NanotrasenRelation { get; set; }
        public int Speciesprefs { get; set; }
        public string Socks { get; set; }
        public string BodyAccessory { get; set; }
        public string Gear { get; set; }
        public bool Autohiss { get; set; }
    }
}

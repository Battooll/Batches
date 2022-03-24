using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class DesktopPribter
    {
        public int IddesktopPribter { get; set; }
        public int? DsId { get; set; }
        public string User { get; set; }
        public string Em { get; set; }
        public int? OfficeId { get; set; }
        public string Ip { get; set; }
        public sbyte? Dc { get; set; }
        public sbyte? Av { get; set; }
        public sbyte? Ex { get; set; }

        public virtual D Ds { get; set; }
        public virtual Office Office { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class Patch
    {
        public int Idpatches { get; set; }
        public int? OfficeId { get; set; }
        public int? PatchNo { get; set; }
        public string PatchSlot { get; set; }
        public int? BoxNo { get; set; }
        public int? RoomNo { get; set; }
        public string Notes { get; set; }

        public virtual Office Office { get; set; }
    }
}

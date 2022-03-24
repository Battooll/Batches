using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class Headofdept
    {
        public int Idheadofdept { get; set; }
        public int? StaffId { get; set; }
        public int? DeptId { get; set; }
        public int? OfficeId { get; set; }

        public virtual Dept Dept { get; set; }
        public virtual Office Office { get; set; }
        public virtual staff Staff { get; set; }
    }
}

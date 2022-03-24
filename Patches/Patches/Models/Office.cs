using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class Office
    {
        public Office()
        {
            DesktopPribters = new HashSet<DesktopPribter>();
            Headofdepts = new HashSet<Headofdept>();
            Patches = new HashSet<Patch>();
            staff = new HashSet<staff>();
        }

        public int Idoffice { get; set; }
        public int? DeptId { get; set; }
        public string Name { get; set; }
        public int? OfficeNo { get; set; }
        public virtual ICollection<DesktopPribter> DesktopPribters { get; set; }
        public virtual ICollection<Headofdept> Headofdepts { get; set; }
        public virtual ICollection<Patch> Patches { get; set; }
        public virtual ICollection<staff> staff { get; set; }
    }
}

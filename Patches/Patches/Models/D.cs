using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class D
    {
        public D()
        {
            DesktopPribters = new HashSet<DesktopPribter>();
        }

        public int Idds { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DesktopPribter> DesktopPribters { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class Building
    {
        public Building()
        {
            Floors = new HashSet<Floor>();
        }

        public int Idbuildings { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Floor> Floors { get; set; }
    }
}

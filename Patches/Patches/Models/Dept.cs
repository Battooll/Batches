using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class Dept
    {
        public Dept()
        {
            Headofdepts = new HashSet<Headofdept>();
        }

        public int Iddepts { get; set; }
        public int? FloorId { get; set; }
        public string Name { get; set; }

        public virtual Floor Floor { get; set; }
        public virtual ICollection<Headofdept> Headofdepts { get; set; }
    }
}

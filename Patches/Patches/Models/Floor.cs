using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class Floor
    {
        public Floor()
        {
            Depts = new HashSet<Dept>();
        }

        public int Idfloors { get; set; }
        public int? Building { get; set; }
        public int? FloorNo { get; set; }

        public virtual Building BuildingNavigation { get; set; }
        public virtual ICollection<Dept> Depts { get; set; }
    }
}

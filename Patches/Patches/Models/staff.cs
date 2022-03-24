using System;
using System.Collections.Generic;

#nullable disable

namespace Patches
{
    public partial class staff
    {
        public staff()
        {
            Headofdepts = new HashSet<Headofdept>();
        }

        public int Idstaff { get; set; }
        public string Name { get; set; }
        public int? OfficeId { get; set; }

        public virtual Office Office { get; set; }
        public virtual ICollection<Headofdept> Headofdepts { get; set; }
    }
}

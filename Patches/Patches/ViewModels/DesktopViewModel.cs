using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patches.ViewModels
{
    public class DesktopViewModel
    {
        public OfficehHierarchyViewModel OfficehHierarchy { get; set; }
        public D ds { get; set; }
        public DesktopPribter desktop { get; set; }
        public List<Patch> Patch { get; set; }
    }
}

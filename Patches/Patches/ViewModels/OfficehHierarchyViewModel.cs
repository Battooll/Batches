using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patches.ViewModels
{
    public class OfficehHierarchyViewModel
    {
        public Building building { get; set; }
        public Floor floor { get; set; }
        public Dept dept { get; set; }
        public Office office { get; set; }
        public Patch patch { get; set; }
        //public string Search { get; set; }
    }
}

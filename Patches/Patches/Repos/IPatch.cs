using Patches.Models;
using Patches.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patches.Repos
{
    public interface IPatch
    {

        public GetVModel GetV();

        Patch AddPatch(Patch patch);
        Patch UpdatePatch(int id, Patch patch);
        int DeletePatch(int id);
        List<OfficehHierarchyViewModel> GatAllPatches();
        //Task<Patch> GetPatch(int id);
        List<OfficehHierarchyViewModel> GetPatch(int id);
        List<OfficehHierarchyViewModel> GetPatchNO(int NO);
        List<Patch> GetPatchesInBuiling1(int building);
        List<OfficehHierarchyViewModel> GetPatchesInBuiling(string building);
        List<Patch> GetPatchesInFloor1(int floor);
        List<OfficehHierarchyViewModel> GetPatchesInFloor(int floor);
        List<Patch> GetPatchesInOffice1(int Office);
        List<OfficehHierarchyViewModel> GetPatchesInOffice(int office);
        List<Patch> GetPatchesInDept1(int dept);
        List<OfficehHierarchyViewModel> GetPatchesInDept(string dept);

    }
}

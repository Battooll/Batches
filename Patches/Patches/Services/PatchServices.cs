using Patches.Models;
using Patches.Repos;
using Patches.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Patches.Services
{
    public class PatchServices : IPatch
    {
        private readonly patchdbContext _db;
        public PatchServices(patchdbContext db)
        {

            _db = db;
        }
        public Patch AddPatch(Patch patch)
        {
            if (_db != null)
            {
                _db.Patches.Add(patch);
                _db.SaveChanges();
                return patch;
            }
            return null;
        }

        public int DeletePatch(int id)
        {
            if (_db != null)
            {
                var isExist = _db.Patches.Where(x => x.Idpatches == id).FirstOrDefault();
                if (isExist != null)
                {
                    _db.Patches.Remove(isExist);
                    _db.SaveChanges();
                    return 1;
                }
                return 0;
            }
            return 0;
        }

        public List<OfficehHierarchyViewModel> GatAllPatches()
        {
            if (_db != null)
            {
                var result = new List<OfficehHierarchyViewModel>();
                var patches =  _db.Patches.Select(x => new Patch
                {
                    Idpatches = x.Idpatches,
                    BoxNo = x.BoxNo,
                    Notes = x.Notes,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    PatchNo = x.PatchNo,
                    PatchSlot = x.PatchSlot,
                    RoomNo = x.RoomNo
                }).ToList();
                foreach (var patch in patches)
                {
                    var temp = new OfficehHierarchyViewModel();
                    temp.patch = patch;
                    temp.office = patch.Office;
                    temp.dept = _db.Depts.Where(x => x.Iddepts == patch.Office.DeptId).FirstOrDefault();
                    temp.floor = _db.Floors.Where(x => x.Idfloors == temp.dept.Iddepts).FirstOrDefault();
                    temp.building = _db.Buildings.Where(x => x.Idbuildings == temp.floor.Building).FirstOrDefault();
                    result.Add(temp);
                }
                return result;
            }
            return null;
        }

        //public async Task<Patch> GetPatch(int id)
        public List<OfficehHierarchyViewModel> GetPatch(int id)
        {
            if (_db != null)
            {
                var result = new List<OfficehHierarchyViewModel>();
                var patches =  _db.Patches.Where(x=> x.Idpatches == id).Select(x => new Patch
                {
                    Idpatches = x.Idpatches,
                    BoxNo = x.BoxNo,
                    Notes = x.Notes,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    PatchNo = x.PatchNo,
                    PatchSlot = x.PatchSlot,
                    RoomNo = x.RoomNo
                }).ToList();
                foreach (var patch in patches)
                {
                    var temp = new OfficehHierarchyViewModel();
                    temp.patch = patch;
                    temp.office = patch.Office;
                    temp.dept = _db.Depts.Where(x => x.Iddepts == patch.Office.DeptId).FirstOrDefault();
                    temp.floor = _db.Floors.Where(x => x.Idfloors == temp.dept.Iddepts).FirstOrDefault();
                    temp.building = _db.Buildings.Where(x => x.Idbuildings == temp.floor.Building).FirstOrDefault();
                    result.Add(temp);
                }
                return result;
            }
            return null;
        }


        public List<OfficehHierarchyViewModel> GetPatchNO(int NO)
        {
            if (_db != null)
            {
                var result = new List<OfficehHierarchyViewModel>();
                var patches = _db.Patches.Where(x => x.PatchNo == NO).Select(x => new Patch
                {
                    Idpatches = x.Idpatches,
                    BoxNo = x.BoxNo,
                    Notes = x.Notes,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    PatchNo = x.PatchNo,
                    PatchSlot = x.PatchSlot,
                    RoomNo = x.RoomNo
                }).ToList();
                foreach (var patch in patches)
                {
                    var temp = new OfficehHierarchyViewModel();
                    temp.patch = patch;
                    temp.office = patch.Office;
                    temp.dept = _db.Depts.Where(x => x.Iddepts == patch.Office.DeptId).FirstOrDefault();
                    temp.floor = _db.Floors.Where(x => x.Idfloors == temp.dept.Iddepts).FirstOrDefault();
                    temp.building = _db.Buildings.Where(x => x.Idbuildings == temp.floor.Building).FirstOrDefault();
                    result.Add(temp);
                }
                return result;
            }
            return null;
        }



        public List<Patch> GetPatchesInBuiling1(int building)
        {
            if (_db != null)
            {
                var result = new List<Patch>();
                var patchesInBuilding = new List<Patch>();
                var floors = _db.Floors.Where(x => x.Building == building).ToList();
                foreach (var floor in floors)
                {
                    int floorNo = Convert.ToInt32(floor.FloorNo);
                    var patchesInFloor = GetPatchesInFloor1(floorNo);
                    foreach (var item in patchesInFloor)
                    {
                        patchesInBuilding.Add(item);
                    }
                }
                result = patchesInBuilding;
                return result;
            }
            return null;
        }

        public List<OfficehHierarchyViewModel> GetPatchesInBuiling(string building)
        {
            if (_db != null)
            {
                var result = new List<OfficehHierarchyViewModel>();
                var buildingIds = _db.Buildings.Where(x => x.Name.Contains(building)).Select(x => x.Idbuildings).ToList();
                foreach (var id in buildingIds)
                {
                    var patchesInBuilding = GetPatchesInBuiling1(id);
                    foreach (var patch in patchesInBuilding)
                    {
                        var temp = new OfficehHierarchyViewModel();
                        temp.office = patch.Office;
                        temp.dept = _db.Depts.Where(x => x.Iddepts == temp.office.DeptId).FirstOrDefault();
                        temp.floor = _db.Floors.Where(x => x.Idfloors == temp.dept.FloorId).FirstOrDefault();
                        temp.building = _db.Buildings.Where(x => x.Idbuildings == id).FirstOrDefault();
                        temp.patch = patch;
                        result.Add(temp);

                    }
                }
                return result;
            }
            return null;
        }




        public List<Patch> GetPatchesInFloor1(int FloorNo)
        {
            if (_db != null)
            {
                var result = new List<Patch>();
                var patchesInFloor = new List<Patch>();
                var floor = _db.Floors.Where(x => x.FloorNo == FloorNo).FirstOrDefault();
                var depts = _db.Depts.Where(x => x.FloorId == floor.Idfloors).ToList();
                foreach (var dept in depts)
                {
                    var patchesInDept = GetPatchesInDept1(dept.Iddepts);
                    foreach (var item in patchesInDept)
                    {
                        patchesInFloor.Add(item);
                    }
                }
                result = patchesInFloor;
                return result;
            }
            return null;
        }

        public List<OfficehHierarchyViewModel> GetPatchesInFloor(int floor)
        {
            if (_db != null)
            {
                var result = new List<OfficehHierarchyViewModel>();
                var patches = GetPatchesInFloor1(floor);

                foreach (var patch in patches)
                {
                    var temp = new OfficehHierarchyViewModel();
                    temp.office = patch.Office;
                    temp.dept = _db.Depts.Where(x => x.Iddepts == temp.office.DeptId).FirstOrDefault();
                    temp.floor = _db.Floors.Where(x => x.Idfloors == temp.dept.FloorId).FirstOrDefault();
                    temp.building = _db.Buildings.Where(x => x.Idbuildings == floor).FirstOrDefault();
                    temp.patch = patch;
                    result.Add(temp);

                }
                return result;
            }
            return null;
        }




        public List<Patch> GetPatchesInDept1(int deptID)
        {
            if (_db != null)
            {
                var result = new List<Patch>();
                var patchesInDept = new List<Patch>();
                var dept = _db.Depts.Where(x => x.Iddepts == deptID).FirstOrDefault();
                var offices = _db.Offices.Where(x => x.DeptId == dept.Iddepts).ToList();
                foreach (var office in offices)
                {
                    var patchesInOffice = GetPatchesInOffice1(office.Idoffice);
                    foreach (var item in patchesInOffice)
                    {
                        patchesInDept.Add(item);
                    }
                }
                result = patchesInDept;
                return result;
            }
            return null;
        }

        public List<OfficehHierarchyViewModel> GetPatchesInDept(string deptName)
        {
            if (_db != null)
            {
                var result = new List<OfficehHierarchyViewModel>();
                var deptIds = _db.Depts.Where(x => x.Name.Contains(deptName)).Select(x => x.Iddepts).ToList();
                foreach (var id in deptIds)
                {
                    var patches = GetPatchesInDept1(id);
                    foreach (var patch in patches)
                    {
                        var temp = new OfficehHierarchyViewModel();
                        temp.office = patch.Office;
                        temp.dept = _db.Depts.Where(x => x.Iddepts == temp.office.DeptId).FirstOrDefault();
                        temp.floor = _db.Floors.Where(x => x.Idfloors == temp.dept.FloorId).FirstOrDefault();
                        temp.building = _db.Buildings.Where(x => x.Idbuildings == temp.floor.Building).FirstOrDefault();
                        temp.patch = patch;
                        result.Add(temp);

                    }
                }
                return result;
            }
            return null;
        }





        public List<Patch> GetPatchesInOffice1(int Office)
        {
            if (_db != null)
            {
                var result = new List<Patch>();
                result = _db.Patches.Where(x => x.OfficeId == Office).Select(x => new Patch
                {
                    Idpatches = x.Idpatches,
                    BoxNo = x.BoxNo,
                    Notes = x.Notes,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    PatchNo = x.PatchNo,
                    PatchSlot = x.PatchSlot,
                    RoomNo = x.RoomNo
                }).ToList();
                return result;
            }
            return null;
        }

        public List<OfficehHierarchyViewModel> GetPatchesInOffice(int office)
        {
            if (_db != null)
            {
                var result = new List<OfficehHierarchyViewModel>();
                var patches = GetPatchesInOffice1(office);

                foreach (var patch in patches)
                {
                    var temp = new OfficehHierarchyViewModel();
                    temp.office = patch.Office;
                    temp.dept = _db.Depts.Where(x => x.Iddepts == temp.office.DeptId).FirstOrDefault();
                    temp.floor = _db.Floors.Where(x => x.Idfloors == temp.dept.FloorId).FirstOrDefault();
                    temp.building = _db.Buildings.Where(x => x.Idbuildings == office).FirstOrDefault();
                    temp.patch = patch;
                    result.Add(temp);

                }
                return result;
            }
            return null;
        }



        public Patch UpdatePatch(int id, Patch patch)
        {
            if (_db != null)
            {
                var isExist = _db.Patches.Where(x => x.Idpatches == id).FirstOrDefault();
                if (isExist != null)
                {
                    isExist.BoxNo = patch.BoxNo;
                    isExist.Notes = patch.Notes;
                    isExist.OfficeId = patch.OfficeId;
                    isExist.PatchNo = patch.PatchNo;
                    isExist.PatchSlot = patch.PatchSlot;
                    isExist.RoomNo = patch.RoomNo;
                    _db.Patches.Update(isExist);
                    _db.SaveChanges();
                    return patch;
                }
                return null;
            }
            return null;
        }

        public GetVModel GetV()
        {
            var v = 1;
            var m = new GetVModel();
            m.v = v + 1;
            return m;
        }

        
    }
}

using Patches.Repos;
using Patches.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patches.Services
{
    public class DesktopServices : IDesktop
    {
        private readonly patchdbContext _db;
        public DesktopServices(patchdbContext db)
        {
            _db = db;
        }
        public DesktopPribter AddDesktop(DesktopPribter desktop)
        {
            if (_db != null)
            {
                _db.DesktopPribters.Add(desktop);
                _db.SaveChanges();
                return desktop;
            }
            return null;
        }

        public int DeleteDesktop(int id)
        {
            if (_db != null)
            {
                var isExist = _db.DesktopPribters.Where(x => x.IddesktopPribter == id).FirstOrDefault();
                if (isExist != null)
                {
                    _db.DesktopPribters.Remove(isExist);
                    _db.SaveChanges();
                    return 1;
                }
                return 0;
            }
            return 0;
        }

        public List<DesktopViewModel> GatAllDesktops()
        {
            if (_db != null)
            {
                var result = new List<DesktopViewModel>();
                var desktops = _db.DesktopPribters.Select(x => new DesktopPribter
                {
                    IddesktopPribter = x.IddesktopPribter,
                    User = x.User,
                    Av = x.Av,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    Dc = x.Dc,
                    Ds = x.Ds,
                    DsId = x.DsId,
                    Em = x.Em,
                    Ex = x.Ex,
                    Ip = x.Ip
                }).ToList();
                foreach (var desktop in desktops)
                {
                    var desktopTemp = new DesktopViewModel();
                    var officeLoc = new OfficehHierarchyViewModel();
                    //temp.patch = patch;
                    officeLoc.office = desktop.Office;
                    officeLoc.dept = _db.Depts.Where(x => x.Iddepts == desktop.Office.DeptId).FirstOrDefault();
                    officeLoc.floor = _db.Floors.Where(x => x.Idfloors == officeLoc.dept.FloorId).FirstOrDefault();
                    officeLoc.building = _db.Buildings.Where(x => x.Idbuildings == officeLoc.floor.Building).FirstOrDefault();

                    desktopTemp.desktop = desktop;
                    desktopTemp.OfficehHierarchy = officeLoc;
                    desktopTemp.ds = desktop.Ds;
                    // Getting Patches
                    var services = new PatchServices(_db);
                    int off = Convert.ToInt32(desktop.OfficeId);
                    var patches = services.GetPatchesInOffice1(off);
                    desktopTemp.Patch = patches;
                    result.Add(desktopTemp);
                }
                return result;
            }
            return null;
        }

        public DesktopViewModel GetDesktop(int id)
        {
            var result = new DesktopViewModel();
            var desktops = _db.DesktopPribters.Where(x => x.IddesktopPribter == id).Select(x => new DesktopPribter
            {
                IddesktopPribter = x.IddesktopPribter,
                User = x.User,
                Av = x.Av,
                Office = x.Office,
                OfficeId = x.OfficeId,
                Dc = x.Dc,
                Ds = x.Ds,
                DsId = x.DsId,
                Em = x.Em,
                Ex = x.Ex,
                Ip = x.Ip
            }).FirstOrDefault();

            var desktopTemp = new DesktopViewModel();
            var officeLoc = new OfficehHierarchyViewModel();
            //temp.patch = patch;
            officeLoc.office = desktops.Office;
            officeLoc.dept = _db.Depts.Where(x => x.Iddepts == desktops.Office.DeptId).FirstOrDefault();
            officeLoc.floor = _db.Floors.Where(x => x.Idfloors == officeLoc.dept.FloorId).FirstOrDefault();
            officeLoc.building = _db.Buildings.Where(x => x.Idbuildings == officeLoc.floor.Building).FirstOrDefault();

            desktopTemp.desktop = desktops;
            desktopTemp.OfficehHierarchy = officeLoc;
            desktopTemp.ds = desktops.Ds;

            // Getting Patches
            var services = new PatchServices(_db);
            int off = Convert.ToInt32(desktops.OfficeId);
            var patches = services.GetPatchesInOffice1(off);
            desktopTemp.Patch = patches;
            result = desktopTemp;

            return result;
        }




        public List<DesktopViewModel> GetDesktopsInDept(int dept)
        {
            throw new NotImplementedException();
        }

        public List<DesktopViewModel> GetDesktopsInFloor(int floor)
        {
            throw new NotImplementedException();
        }

        public List<DesktopViewModel> GetDesktopsInOffice(int Office)
        {
            throw new NotImplementedException();
        }

        public List<DesktopViewModel> GetPatchesInBuiling(int building)
        {
            throw new NotImplementedException();
        }

        public DesktopPribter UpdateDesktop(int id, DesktopPribter desktop)
        {
            if (_db != null)
            {
                var isExist = _db.DesktopPribters.Where(x => x.IddesktopPribter == id).FirstOrDefault();
                if (isExist != null)
                {
                    isExist.Av = desktop.Av;
                    isExist.Dc = desktop.Dc;
                    isExist.DsId = desktop.DsId;
                    isExist.Em = desktop.Em;
                    isExist.Ex = desktop.Ex;
                    isExist.Ip = desktop.Ip;
                    isExist.OfficeId = desktop.OfficeId;
                    isExist.User = desktop.User;
                    _db.DesktopPribters.Update(isExist);
                    _db.SaveChanges();
                    return desktop;
                }
                return null;
            }
            return null;
        }



        public List<DesktopViewModel> GetDeviceName(string device)
        {
            if (_db != null)
            {
                var result = new List<DesktopViewModel>();
                var dss = _db.Ds.Where(x => x.Name == device).Select(x => x.Idds).FirstOrDefault();
                var desktops = _db.DesktopPribters.Where(x=>x.DsId == dss).Select(x => new DesktopPribter
                {
                    IddesktopPribter = x.IddesktopPribter,
                    User = x.User,
                    Av = x.Av,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    Dc = x.Dc,
                    Ds = x.Ds,
                    DsId = x.DsId,
                    Em = x.Em,
                    Ex = x.Ex,
                    Ip = x.Ip
                }).ToList();
                foreach (var desktop in desktops)
                {
                    var desktopTemp = new DesktopViewModel();
                    var officeLoc = new OfficehHierarchyViewModel();
                    //temp.patch = patch;
                    officeLoc.office = desktop.Office;
                    officeLoc.dept = _db.Depts.Where(x => x.Iddepts == desktop.Office.DeptId).FirstOrDefault();
                    officeLoc.floor = _db.Floors.Where(x => x.Idfloors == officeLoc.dept.FloorId).FirstOrDefault();
                    officeLoc.building = _db.Buildings.Where(x => x.Idbuildings == officeLoc.floor.Building).FirstOrDefault();

                    desktopTemp.desktop = desktop;
                    desktopTemp.OfficehHierarchy = officeLoc;
                    desktopTemp.ds = desktop.Ds;
                    // Getting Patches
                    var services = new PatchServices(_db);
                    int off = Convert.ToInt32(desktop.OfficeId);
                    var patches = services.GetPatchesInOffice1(off);
                    desktopTemp.Patch = patches;
                    result.Add(desktopTemp);
                }
                return result;
            }
            return null;
        }



        public List<DesktopViewModel> GetIP(string ip)
        {
            if (_db != null)
            {
                var result = new List<DesktopViewModel>();
                
                var desktops = _db.DesktopPribters.Where(x => x.Ip == ip).Select(x => new DesktopPribter
                {
                    IddesktopPribter = x.IddesktopPribter,
                    User = x.User,
                    Av = x.Av,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    Dc = x.Dc,
                    Ds = x.Ds,
                    DsId = x.DsId,
                    Em = x.Em,
                    Ex = x.Ex,
                    Ip = x.Ip
                }).ToList();
                foreach (var desktop in desktops)
                {
                    var desktopTemp = new DesktopViewModel();
                    var officeLoc = new OfficehHierarchyViewModel();
                    //temp.patch = patch;
                    officeLoc.office = desktop.Office;
                    officeLoc.dept = _db.Depts.Where(x => x.Iddepts == desktop.Office.DeptId).FirstOrDefault();
                    officeLoc.floor = _db.Floors.Where(x => x.Idfloors == officeLoc.dept.FloorId).FirstOrDefault();
                    officeLoc.building = _db.Buildings.Where(x => x.Idbuildings == officeLoc.floor.Building).FirstOrDefault();

                    desktopTemp.desktop = desktop;
                    desktopTemp.OfficehHierarchy = officeLoc;
                    desktopTemp.ds = desktop.Ds;
                    // Getting Patches
                    var services = new PatchServices(_db);
                    int off = Convert.ToInt32(desktop.OfficeId);
                    var patches = services.GetPatchesInOffice1(off);
                    desktopTemp.Patch = patches;
                    result.Add(desktopTemp);
                }
                return result;
            }
            return null;
        }


        public List<DesktopViewModel> GetUser(string User)
        {
            if (_db != null)
            {
                var result = new List<DesktopViewModel>();

                var desktops = _db.DesktopPribters.Where(x => x.User.ToLower() == User.ToLower()).Select(x => new DesktopPribter
                {
                    IddesktopPribter = x.IddesktopPribter,
                    User = x.User,
                    Av = x.Av,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    Dc = x.Dc,
                    Ds = x.Ds,
                    DsId = x.DsId,
                    Em = x.Em,
                    Ex = x.Ex,
                    Ip = x.Ip
                }).ToList();
                foreach (var desktop in desktops)
                {
                    var desktopTemp = new DesktopViewModel();
                    var officeLoc = new OfficehHierarchyViewModel();
                    //temp.patch = patch;
                    officeLoc.office = desktop.Office;
                    officeLoc.dept = _db.Depts.Where(x => x.Iddepts == desktop.Office.DeptId).FirstOrDefault();
                    officeLoc.floor = _db.Floors.Where(x => x.Idfloors == officeLoc.dept.FloorId).FirstOrDefault();
                    officeLoc.building = _db.Buildings.Where(x => x.Idbuildings == officeLoc.floor.Building).FirstOrDefault();

                    desktopTemp.desktop = desktop;
                    desktopTemp.OfficehHierarchy = officeLoc;
                    desktopTemp.ds = desktop.Ds;
                    // Getting Patches
                    var services = new PatchServices(_db);
                    int off = Convert.ToInt32(desktop.OfficeId);
                    var patches = services.GetPatchesInOffice1(off);
                    desktopTemp.Patch = patches;
                    result.Add(desktopTemp);
                }
                return result;
            }
            return null;
        }



        public List<DesktopViewModel> GetUserName(string UserName)
        {
            if (_db != null)
            {
                var result = new List<DesktopViewModel>();

                var desktops = _db.DesktopPribters.Where(x => x.Em.ToLower().Contains(UserName.ToLower())).Select(x => new DesktopPribter
                {
                    IddesktopPribter = x.IddesktopPribter,
                    User = x.User,
                    Av = x.Av,
                    Office = x.Office,
                    OfficeId = x.OfficeId,
                    Dc = x.Dc,
                    Ds = x.Ds,
                    DsId = x.DsId,
                    Em = x.Em,
                    Ex = x.Ex,
                    Ip = x.Ip
                }).ToList();
                foreach (var desktop in desktops)
                {
                    var desktopTemp = new DesktopViewModel();
                    var officeLoc = new OfficehHierarchyViewModel();
                    //temp.patch = patch;
                    officeLoc.office = desktop.Office;
                    officeLoc.dept = _db.Depts.Where(x => x.Iddepts == desktop.Office.DeptId).FirstOrDefault();
                    officeLoc.floor = _db.Floors.Where(x => x.Idfloors == officeLoc.dept.FloorId).FirstOrDefault();
                    officeLoc.building = _db.Buildings.Where(x => x.Idbuildings == officeLoc.floor.Building).FirstOrDefault();

                    desktopTemp.desktop = desktop;
                    desktopTemp.OfficehHierarchy = officeLoc;
                    desktopTemp.ds = desktop.Ds;
                    // Getting Patches
                    var services = new PatchServices(_db);
                    int off = Convert.ToInt32(desktop.OfficeId);
                    var patches = services.GetPatchesInOffice1(off);
                    desktopTemp.Patch = patches;
                    result.Add(desktopTemp);
                }
                return result;
            }
            return null;
        }
    }
}

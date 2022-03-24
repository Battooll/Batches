using Patches.Models;
using Patches.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patches.Repos
{
    public interface IDesktop
    {

        DesktopPribter AddDesktop(DesktopPribter desktop);
        DesktopPribter UpdateDesktop(int id, DesktopPribter desktop);
        int DeleteDesktop(int id);
        List<DesktopViewModel> GatAllDesktops();
        DesktopViewModel GetDesktop(int id);
        List<DesktopViewModel> GetPatchesInBuiling(int building);
        List<DesktopViewModel> GetDesktopsInFloor(int floor);
        List<DesktopViewModel> GetDesktopsInOffice(int Office);
        List<DesktopViewModel> GetDesktopsInDept(int dept);


        List<DesktopViewModel> GetDeviceName(string device);
        List<DesktopViewModel> GetIP(string ip);
        List<DesktopViewModel> GetUser(string ip);
        List<DesktopViewModel> GetUserName(string ip);
    }
}

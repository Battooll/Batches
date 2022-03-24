using Microsoft.AspNetCore.Mvc;
using Patches.Repos;
using Patches.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patches.Controllers
{
    public class DesktopController : Controller
    {
        private readonly IDesktop _desk;
        private readonly patchdbContext _db;
        public DesktopController(patchdbContext db, IDesktop desk)
        {
            _db = db;
            _desk = desk;
        }
        [HttpGet]
        public IActionResult Index(string searchBy, string search)
        {
            
            if (searchBy == "Device Name")
            {
                var x = _desk.GetDeviceName(search);
                return View(x);
            }
            else if (searchBy == "IP")
            {
                var x = _desk.GetIP(search);
                return View(x);
            }
            else if (searchBy == "User")
            {
                var x = _desk.GetUser(search);
                return View(x);
            }
            else if (searchBy == "Em")
            {
                var x = _desk.GetUserName(search);
                return View(x);
            }
            else
            {
                var desktops = _desk.GatAllDesktops();
                return View(desktops);
            }
        }
        public IActionResult addDesktop()
        {
            var desktop = new DesktopPribter();
            return View("addDesktop", desktop);
        }
        [HttpPost]
        public IActionResult addDesktop(DesktopPribter desktop)
        {
            var desktops = _desk.AddDesktop(desktop);
            return View(desktops);
        }

        //public IActionResult EditDesktop()
        //{
        //    var d = new DesktopPribter();
        //    int id = d.IddesktopPribter;
        //    return View("EditDesktop", d, id);
        //}
        public ActionResult EditDesktop()
        {
            DesktopPribter desk = new DesktopPribter();
            return View("EditDesktop", desk);
        }
        [HttpPost]
        public IActionResult EditDesktop(int id, DesktopPribter de)
        {
            var edited = _desk.UpdateDesktop(id, de);
            return View(edited);
        }
        
        public IActionResult DeletePatch()
        {

            var d = new DesktopPribter();
            int id = d.IddesktopPribter;
            return View("DeleteDesktop", id);
        }
        [HttpDelete]
        public IActionResult DeleteDesktop(int id)
        {
            var v = _desk.DeleteDesktop(id);

            return View("index");
        }

        [HttpGet]
        public IActionResult desktopDetails(int id)
        {
            var d = _desk.GetDesktop(id);

            return View(d);
        }
    }
}

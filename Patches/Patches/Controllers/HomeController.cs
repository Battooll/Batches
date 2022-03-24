using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Patches.Models;
using Patches.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Yamama.ViewModels;

namespace Patches.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPatch _pa;
        private readonly patchdbContext _db;
        public HomeController(ILogger<HomeController> logger, IPatch pa, patchdbContext db)
        {
            _logger = logger;
            _db = db;
            _pa = pa;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult patches()
        {
            var patch = _pa.GatAllPatches();
            return View(patch);
        }

        public ActionResult AddPatch()
        {
            Patch patch = new Patch();
            return View("AddPatch", patch);
        }
        [HttpPost]
        public IActionResult AddPatch(Patch patch)
        {
            var res = _pa.AddPatch(patch);
            //var id = res.Idpatches;
            return View(res);
        }

        //[HttpPut]
        public ActionResult EditPatch()
        {
            Patch patch = new Patch();
            return View("EditPatch", patch);
        }
        [HttpPost]
        public IActionResult EditPatch (int id, Patch patch)
        {
            //var v = _pa.GetPatch(id);

            var edited = _pa.UpdatePatch(id, patch);
            return View(edited);
        }


        [HttpDelete]
        public IActionResult DeletePatch(int id)
        {
            var v = _pa.DeletePatch(id);

            return View("index");
        }

        [HttpGet]
        public IActionResult PatchDetails(int id)
        {
            var v = _pa.GetPatch(id);

            return View(v);
        }

        [HttpGet]
        public IActionResult patchInBuilding(string building)
        {
            var v = _pa.GetPatchesInBuiling(building);

            return View(v);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }







        public ActionResult Index1(string searchBy, string search)
        {
            if (searchBy == "Building")
            {
                var x = _pa.GetPatchesInBuiling(search);
                return View(x);
            }
            else if (searchBy == "Floor")
            {
                var s = Convert.ToInt32(search);
                var x = _pa.GetPatchesInFloor(s);
                return View(x);
            }
            else if (searchBy == "Office")
            {
                var s = Convert.ToInt32(search);
                var x = _pa.GetPatchesInOffice(s);
                return View(x);
            }
            else if (searchBy == "Dept")
            {
                var x = _pa.GetPatchesInDept(search);
                return View(x);
            }
            else if (searchBy == "Patch")
            {
                var s = Convert.ToInt32(search);
                var x = _pa.GetPatchNO(s);
                return View(x);
            }
            else
            {
                var x = _pa.GatAllPatches();
                return View(x);
            }
        }
    }
}

using ArmyTechTask.Services;
using ArmyTechTask.viewModels.Branch;
using ArmyTechTask.viewModels.Cacher;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArmyTechTask.Controllers
{
    [Route("[controller]")]
    public class CacherController : Controller
    {
        private ICacherService cacherService; 

        public CacherController(ICacherService cacherService )
        {
            this.cacherService = cacherService; 
        }
        [HttpGet] 
        [Route("Get/{id}")]
        public CacherDetailsVM Get(int id)
        {
            return cacherService.GetCacherById(id); 
        }
        [HttpGet]
        public IActionResult Index()
        {
            //TempData.Keep("message");
            //TempData.Keep("type");
            var x = TempData;
            var result = cacherService.GetAll();
            ViewBag.CachierList = result;
            return View();
        }
        [HttpPost]
        [Route("AddCacher")]
        public IActionResult AddCacher(CacherAddVM entity)
        {
            if (ModelState.IsValid)
            {
                var result = cacherService.AddCacher(entity);
                if (result.Success)
                {
                    TempData["success"] = "Successfully Added Cashier"; 
                }
                else
                {
                    TempData["error"] = "Failed to Add Cashier"; 
                }
            }
            else
            {
                TempData["error"] = "Form Not Correct "; 
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("UpdateCacher")]
        public IActionResult UpdateCacher(CacherAddVM entity)
        {
            if (ModelState.IsValid)
            {
               var result= cacherService.UpdateCacher(entity);
                if (result.Success)
                { 
                    TempData["success"] = "Successfully Update Cashier"; 
                }
                else
                {
                    TempData["error"] = "Failed to Update Cashier"; 
                } 
            }
            else
            {
                TempData["error"] = "Form Not Correct "; 
            }
            return RedirectToAction("Index");
        } 

        [Route("deleteCacher")]
        public IActionResult deleteCacher(int id)
        {
            var result = cacherService.DeleteCacher(id);
            if (result.Success)
            {
                TempData["success"] = "Successfully delete Cashier"; 
            }
            else
            {
                TempData["error"] = "Failed to delete Cashier"; 
            }
            return RedirectToAction("Index");
        } 
    }
}

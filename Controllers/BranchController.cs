using ArmyTechTask.Services;
using ArmyTechTask.viewModels.Branch;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArmyTechTask.Controllers
{
    [Route("[controller]")]
    public class BranchController : Controller
    {
        private IBranchService branchService;

        public BranchController(IBranchService branchService)
        {
            this.branchService = branchService;
        } 

        [HttpGet]
        [Route("GetAllBranches")]
        public List<BranchVM> GetAllBranches()
        {
            return branchService.GetAll();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

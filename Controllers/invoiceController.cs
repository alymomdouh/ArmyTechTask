using Microsoft.AspNetCore.Mvc;

namespace ArmyTechTask.Controllers
{
    public class invoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    //PM> Scaffold-DbContext "Server=.;Database=ArmyTechTask;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Domains

}

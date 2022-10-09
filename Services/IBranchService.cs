using ArmyTechTask.viewModels.Branch;
using System.Collections.Generic;

namespace ArmyTechTask.Services
{
    public interface IBranchService
    {
        List<BranchVM> GetAll();
    }
}

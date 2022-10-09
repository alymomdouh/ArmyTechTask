using ArmyTechTask.Domains;

namespace ArmyTechTask.Repository
{
    public class BranchRepository : GenericRepository<Branch>, IBranchRepository
    {
        public BranchRepository(ArmyTechTaskContext context) : base(context) { }
    }
}

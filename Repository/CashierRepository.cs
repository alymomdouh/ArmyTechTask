using ArmyTechTask.Domains;

namespace ArmyTechTask.Repository
{
    public class CashierRepository : GenericRepository<Cashier>, ICashierRepository
    {
        public CashierRepository(ArmyTechTaskContext context) : base(context)
        {

        }
    }
}

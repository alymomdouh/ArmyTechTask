using ArmyTechTask.Domains;

namespace ArmyTechTask.Repository
{
    public class InvoiceRepository : GenericRepository<InvoiceHeader>, IInvoiceRepository
    {
        public InvoiceRepository(ArmyTechTaskContext context) : base(context) { }
    }
    
}

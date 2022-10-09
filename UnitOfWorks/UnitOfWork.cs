using ArmyTechTask.Domains;
using ArmyTechTask.Repository;
using ArmyTechTask.viewModels;

namespace ArmyTechTask.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private ArmyTechTaskContext context;
        public UnitOfWork(ArmyTechTaskContext context)
        {
            this.context = context;
            CashierRepository = new CashierRepository(this.context);
            InvoiceRepository = new InvoiceRepository(this.context);
            BranchRepository=new BranchRepository(this.context);
        }
        public ICashierRepository CashierRepository { get; set; }
        public IInvoiceRepository InvoiceRepository { get; set; }
        public IBranchRepository BranchRepository { get; set; }

        public void Dispose()
        {
            context.Dispose();
        }
        public ResultModel Save()
        {
            var affectedRowsCount = context.SaveChanges();
            return (affectedRowsCount > 0)
                ? new ResultModel { Success = true, Message = "Changes have been written to the database successfully." } :
                 new ResultModel { Success = false, Message = "No changes have been written to the database." };
        }
    }
}

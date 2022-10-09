using ArmyTechTask.Repository;
using ArmyTechTask.viewModels;

namespace ArmyTechTask.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICashierRepository CashierRepository { get; set; }
        IInvoiceRepository InvoiceRepository { get; set; }
        IBranchRepository BranchRepository { get; set; }
        
        ResultModel Save();
    }
}

using ArmyTechTask.UnitOfWorks;
using ArmyTechTask.viewModels.Branch;
using AutoMapper;
using System.Collections.Generic;

namespace ArmyTechTask.Services
{
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public BranchService(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = _mapper;
        }
        public List<BranchVM> GetAll()
        { 
            var Cashieres = unitOfWork.BranchRepository.GetAll(X=>X.City);
            var result = mapper.Map<List<BranchVM>>(Cashieres);
            return result;
        } 
    }
}

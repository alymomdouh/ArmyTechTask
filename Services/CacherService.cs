using ArmyTechTask.Domains;
using ArmyTechTask.UnitOfWorks;
using ArmyTechTask.viewModels;
using ArmyTechTask.viewModels.Cacher;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace ArmyTechTask.Services
{
    public class CacherService : ICacherService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CacherService(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = _mapper;
        }

        public List<CacherVM> GetAll()
        {
            var Cashieres = unitOfWork.CashierRepository.GetAll(x => x.Branch);
            var result = mapper.Map<List<CacherVM>>(Cashieres);
            return result;
        }
        public ResultModel AddCacher(CacherAddVM entity)
        {
            var result = mapper.Map<Cashier>(entity);
            unitOfWork.CashierRepository.Add(result);
            return unitOfWork.Save();
        }
        public ResultModel UpdateCacher(CacherAddVM entity)
        {
            var result = mapper.Map<Cashier>(entity);
            unitOfWork.CashierRepository.Update(result);
            return unitOfWork.Save();
        }
        public ResultModel DeleteCacher(int CacherId)
        {
            var result = unitOfWork.CashierRepository.GetById(CacherId);
            unitOfWork.CashierRepository.Remove(result);
            return unitOfWork.Save();
        }
        public CacherDetailsVM GetCacherById(int CacherId)
        {
            var CashierEntity = unitOfWork.CashierRepository.Find<Cashier>(x => x.Id == CacherId, c => c.Branch).FirstOrDefault();
            var result = mapper.Map<CacherDetailsVM>(CashierEntity);
            return result;
        }

    }
}

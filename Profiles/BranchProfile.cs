using ArmyTechTask.Domains;
using ArmyTechTask.viewModels.Branch;
using AutoMapper;

namespace ArmyTechTask.Profiles
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<Branch, BranchVM>();
        }
    }
}

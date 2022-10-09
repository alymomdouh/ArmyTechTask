using ArmyTechTask.Domains;
using ArmyTechTask.viewModels.Cacher;
using AutoMapper;

namespace ArmyTechTask.Profiles
{
    public class CacherProfile : Profile
    {
        
        public CacherProfile()
        {
            // for list
            CreateMap<Cashier, CacherVM>()
                .ForMember(des => des.BranchName, opt => opt.MapFrom(src => src.Branch.BranchName ));

            /// for create 
            CreateMap<CacherAddVM, Cashier>() ;
            // for details 
            CreateMap<Cashier, CacherDetailsVM>()
                .ForMember(des => des.BranchName, opt => opt.MapFrom(src => src.Branch.BranchName));
        }
    }
}

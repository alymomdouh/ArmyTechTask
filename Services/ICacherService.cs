using ArmyTechTask.viewModels;
using ArmyTechTask.viewModels.Cacher;
using System.Collections.Generic;

namespace ArmyTechTask.Services
{
    public interface ICacherService
    {
        List<CacherVM> GetAll(); 
        ResultModel AddCacher(CacherAddVM entity);
        ResultModel UpdateCacher(CacherAddVM entity);
        ResultModel DeleteCacher(int CacherId);
        CacherDetailsVM GetCacherById(int CacherId);
    }
}

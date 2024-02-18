using AutoMapper;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>().ReverseMap();
        }
    }
}

using LeaveManagment.Web.Contracts;
using LeaveManagment.Web.Data;

namespace LeaveManagment.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

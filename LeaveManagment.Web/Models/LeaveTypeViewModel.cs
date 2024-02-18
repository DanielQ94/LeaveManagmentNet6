using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Web.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        public string? Name { get; set; }

        [Display(Name="Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}

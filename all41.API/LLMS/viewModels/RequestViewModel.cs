using LLMS.Models;
using System.ComponentModel.DataAnnotations;

namespace LLMS.viewModels
{
    public class RequestViewModel
    {
        public int RequestId { get; set; }
        public User Requestor { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public string Target { get; set; }
        [Required]
        public string Semester { get; set; }
        [Required]
        public string CostCenter { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public string Approval { get; set; }
    }
}

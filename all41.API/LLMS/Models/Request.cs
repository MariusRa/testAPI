

namespace LLMS.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public User Requestor { get; set; }

        public string Student { get; set; }
        public LearningLanguage Language { get; set; }
        public LearningTarget Target { get; set; }
        public LearningSemester Semester { get; set; }
        
        public string CostCenter { get; set; }
        public string Comments { get; set; }
        
        public bool IsApproved { get; set; }
    }
}

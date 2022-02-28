using LLMS.Models;
using System.Collections.Generic;

namespace LLMS.Services
{
    public interface IRequestService
    {
        IEnumerable<LearningLanguage> GetLearningLanguages();
        IEnumerable<LearningTarget> GetLearningTargets();
        IEnumerable<LearningSemester> GetLearningSemesters();
    }
}

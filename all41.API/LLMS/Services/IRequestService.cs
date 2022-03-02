using LLMS.Models;
using System.Collections.Generic;

namespace LLMS.Services
{
    public interface IRequestService
    {
        IEnumerable<LearningLanguage> GetLearningLanguages();
        IEnumerable<LearningTarget> GetLearningTargets();
        IEnumerable<LearningSemester> GetLearningSemesters();

        Request AddNewRequest(Request request, string requestorId);
        Request SetApprovalStatus(int id, string value);


        IEnumerable<Request> GetAllRequests();
        IEnumerable<Request> GetAllUserRequests(string userId);
    }
}

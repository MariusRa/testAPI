using LLMS.DAL;
using LLMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace LLMS.Services
{
    public class RequestService : IRequestService
    {
        private readonly ApplicationDbContext _db;

        public RequestService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<LearningLanguage> GetLearningLanguages()
        {
            return _db.LearningLanguages.ToList();  
        }
        
        public IEnumerable<LearningSemester> GetLearningSemesters()
        {
            return _db.LearningSemesters.ToList();
        }

        public IEnumerable<LearningTarget> GetLearningTargets()
        {
            return _db.LearningTargets.ToList(); 
        }

        public Request AddNewRequest(Request request, string requestorId)
        {
            request.Requestor = _db.Users.Where(r => r.UserId == requestorId).SingleOrDefault();
            _db.Requests.Add(request);
            _db.SaveChanges();

            return request;
        }

        public IEnumerable<Request> GetAllRequests()
        {
            return _db.Requests.ToList();
        }

        public IEnumerable<Request> GetAllUserRequests(string userId)
        {
            return _db.Requests.Where(u => u.Requestor.UserId == userId).ToList();
        }

        public Request SetApprovalStatus(int id, string value)
        {
            var request = _db.Requests.FirstOrDefault(r => r.RequestId == id);
            request.Approval = value;

            _db.SaveChanges();

            return request;
        }
    }
}

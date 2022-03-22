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

        public Request AddNewRequest(Request request)
        {
            //request.RequestorId = _db.Users.Where(r => r.UserId == requestorId).SingleOrDefault();
            var newRequest = _db.Requests.FirstOrDefault(r => r.StudentEmail == request.StudentEmail && r.Language == request.Language && r.Semester == request.Semester);
            
            if (newRequest == null)
            {
              _db.Requests.Add(request);
              _db.SaveChanges();
              return (request);  
            }
            else
            {
                return null;
            }
            
        }

        public IEnumerable<Request> GetAllRequests()
        {
            return _db.Requests.ToList();
        }

        public IEnumerable<Request> GetAllUserRequests(string userId)
        {
            return _db.Requests.Where(u => u.RequestorId == userId).ToList();
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

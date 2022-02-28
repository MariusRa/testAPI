using LLMS.DAL;
using LLMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;


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
    }
}

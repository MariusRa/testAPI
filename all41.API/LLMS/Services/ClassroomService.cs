using LLMS.DAL;
using LLMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LLMS.Services
{
    public class ClassroomService : IClassroomService
    {
        private readonly ApplicationDbContext _db;

        public ClassroomService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Classroom> GetAllClassrooms()
        {
            return _db.Classrooms.Include(u => u.Users).ToList();
        }

        public Classroom GetClassById(int classId)
        {
            return _db.Classrooms.Include(u => u.Users).FirstOrDefault(c => c.ClassroomId == classId);
        }

        public Classroom SaveClassroom(Classroom classroom)
        {
            _db.Add(classroom);
            _db.SaveChanges();

            return classroom;
        }
    }
}

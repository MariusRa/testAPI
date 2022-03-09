using LLMS.Models;
using System.Collections.Generic;

namespace LLMS.Services
{
    public interface IClassroomService
    {
        IEnumerable<Classroom> GetAllClassrooms();
        Classroom GetClassById(int classId);
        Classroom SaveClassroom(Classroom classroom);
    }
}

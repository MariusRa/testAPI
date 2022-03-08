using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLMS.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string Language { get; set; }
        public string LanguageLevel { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

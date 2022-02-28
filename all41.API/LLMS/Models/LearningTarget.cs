using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLMS.Models
{
    public class LearningTarget
    {
        public int Id { get; set; }
        public string Target { get; set; }

        public List<Request> RequestTarget { get; set; }
    }
}

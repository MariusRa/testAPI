using System.Collections.Generic;

namespace LLMS.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }

        public List<Request> UserRequests { get; set; }
    }
}

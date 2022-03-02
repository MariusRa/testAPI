using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LLMS.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        
        
        [JsonIgnore]
        public List<Request> UserRequests { get; set; }
    }
}

﻿using LLMS.Models;
using System.Collections.Generic;

namespace LLMS.viewModels
{
    public class ClassroomViewModel
    {
        public string ClassroomId { get; set; }
        //public string UniqueId { get; set; }
        public string Language { get; set; }
        public string LanguageLevel { get; set; }
        public bool IsActive { get; set; }
        public string UserId { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace FileStorage.Model
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }

        //public virtual ICollection<File> Files { get; set; }
    }
}
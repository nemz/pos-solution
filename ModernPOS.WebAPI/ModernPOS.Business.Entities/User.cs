﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernPOS.Business.Entities
{
    public class User
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public User UserId  { get; set; }
    }
}
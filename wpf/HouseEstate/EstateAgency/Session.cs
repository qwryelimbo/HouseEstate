﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedUserID
{
    public static class Session
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
    }
}

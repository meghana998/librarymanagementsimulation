﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AuthorizationService
{
    public partial class User
    {
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Passcode { get; set; }
    }
}

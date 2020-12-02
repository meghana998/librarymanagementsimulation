using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Client.Models
{
    public class LoginViewModel
    {
        [System.ComponentModel.DefaultValue(0)]
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Passcode { get; set; }
    }
}

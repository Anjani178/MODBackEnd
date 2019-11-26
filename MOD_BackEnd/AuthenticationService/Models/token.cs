using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Models
{
    public class token
    {
            public string message { get; set; }
            public string tokenval { get; set; }

            public string username { get; set; }
            public string role { get; set; }
    }
}

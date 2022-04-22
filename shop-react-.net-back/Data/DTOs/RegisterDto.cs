using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_react_.net_back.Data.DTOs
{
    public class RegisterDto : LoginDto // dziedzieczymy po LoginDto, bo LoginDto ma UserName i Password
    {
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        // public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }

    }
}
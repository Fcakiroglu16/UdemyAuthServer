using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.Models
{
    public class UserApp : IdentityUser
    {
        public string City { get; set; }

        public DateTime BirthDate { get; set; }
    }

   
}
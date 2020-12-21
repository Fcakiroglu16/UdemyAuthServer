using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.DTOs
{
    public class UserAppDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public string City { get; set; }
    }
}
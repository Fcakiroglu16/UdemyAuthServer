using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.DTOs
{
    public class ClientLoginDto
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
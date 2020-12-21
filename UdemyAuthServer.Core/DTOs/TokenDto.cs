using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyAuthServer.Core.DTOs
{
    public class TokenDto
    {
        public string AccessToken { get; set; }

        public DateTime AccessTokenExpiration { get; set; }

        public string RefreshToken { get; set; }

        public DateTime RefreshTokenExpiration { get; set; }
    }
}
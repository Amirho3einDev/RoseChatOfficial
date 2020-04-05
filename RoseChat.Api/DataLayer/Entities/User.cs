using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoseChat.Api.DataLayer.Entities
{
    public class User
    {
        public int userId { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

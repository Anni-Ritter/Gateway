using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway.ExternalServicePkg
{
    public class ExternalService
    {
        public User GetUserById(int userId)
        {
            return new User { Id = userId, Name = $"User{userId}" };
        }
    }
}

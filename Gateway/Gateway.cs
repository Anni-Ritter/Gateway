using Gateway.ExternalServicePkg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway
{
    public class GatewayService
    {
        private ExternalService externalService;

        public GatewayService()
        {
            this.externalService = new ExternalService();
        }

        public User GetUserById(int userId)
        {
            Console.WriteLine($"Gateway: Requesting user with ID {userId}...");

            User user = externalService.GetUserById(userId);

            Console.WriteLine($"Gateway: Received user {user.Name}");

            return user;
        }
    }
}

using Gateway;
using Gateway.ExternalServicePkg;
using System;

class Program
{
    static void Main()
    {
        GatewayService gateway = new GatewayService();

        User user = gateway.GetUserById(1);

        Console.ReadKey();
    }
}

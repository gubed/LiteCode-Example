using SecureSocketProtocol3.Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LiteCode_Server
{
    class Program
    {
        public static SortedList<string, User.UserDbInfo> Users;
        static void Main(string[] args)
        {
            Server server = new Server();
            Console.Title = "LiteCode Server";
            Users = new SortedList<string, User.UserDbInfo>();

            Process.GetCurrentProcess().WaitForExit();

        }
    }
}

using LiteCode.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiteCode_Server
{
    public class SharedBuilder : ISharedClass
    {
        public SharedBuilder()
        {

        }

        //15 second timeout
        [RemoteExecution(15000, null)]
        public string secretData()
        {
            return "this is the secret data!";
        }

    }
}

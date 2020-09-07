using Property_Sets.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets.Config
{
   public static class Socket
    {
        public static IManageDpt calc => new ManageDpt();
    }
}

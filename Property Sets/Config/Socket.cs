using Property_Sets.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Property_Sets.Config
{
   public static class Socket
    {
        /// <summary>
        /// This class creates interface instances for dependency injection
        /// </summary>
        public static IManageDpt calc => new ManageDpt();
        public static IManageEmp calec => new ManageEmp();
    }
}

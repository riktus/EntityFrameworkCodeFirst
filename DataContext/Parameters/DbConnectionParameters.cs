using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataContext.Parameters
{
    public class DbConnectionParameters
    {
        public string DbServerUrl { get; set; }
        public string DbInstanceName { get; set; }
        public string ConnectionUserName { get; set; }
        public string ConnectionUserPassword { get; set; }
        public bool IsOsUser { get; set; }
        public string LocalDbFileCatalog { get; set; }
        public bool IsLocalDatabase { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WikiCollege.Common
{
    [Serializable]
    public class AccountLogin
    {
        public int accID { set; get; }
        public string UserName { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudendsDB;

using Westwind.Web;
using Westwind.Utilities;
using System.Web;
using System.Configuration;

namespace StudendsView
{
    public class Studnets : CallbackHandler
    {
        [CallbackMethod]
        public string GetJason()
        {
            return SearchStudents.GetJason();
        }
    }
}
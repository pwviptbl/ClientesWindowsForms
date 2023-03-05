using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApp.Controllers
{
    class Security
    {
        public static Boolean checkSQLInjectionArray(Array array)
        {
            bool isSQLInjection = false;
            foreach (var item in array) {
                isSQLInjection = checkSQLInjection(item.ToString());
            }
            return isSQLInjection;
        }
        public static Boolean checkSQLInjection(string Input)
        {
            bool isSQLInjection = false;
            string[] sqlCheckList = { "--", ";--", ";", "/*", "*/", "@@", "@" };
            string[] sqlCheckList2 = { "alter", "create", "declare", "delete", "drop", "insert", "select", "update ", "union ", "truncate", "waitfor" };
            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                if ((Input.IndexOf(sqlCheckList[i], StringComparison.OrdinalIgnoreCase) >= 0))
                { isSQLInjection = true; }
            }

            for (int i = 0; i <= sqlCheckList2.Length - 1; i++)
            {
                if ((Input.IndexOf(sqlCheckList2[i], StringComparison.OrdinalIgnoreCase) >= 0))
                { isSQLInjection = true; }
            }

            return isSQLInjection;
        }
    }
}

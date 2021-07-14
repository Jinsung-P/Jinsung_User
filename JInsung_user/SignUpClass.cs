using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JInsung_user
{
    class SignUpClass
    {
        public bool IdSpecialCharater(String id)
        {
            //string str = @"[~!@\#$%^&*\()\=+|\\/:;?""<>']";
            string str = @"[~!@\#$%^&*\()\=+|\\/:;?""<>'가-힣]";
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(str);
            return rex.IsMatch(id);
        }

    }
}

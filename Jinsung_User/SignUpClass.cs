using System;
using System.Collections.Generic;
using System.Text;

namespace Jinsung_User
{
    class SignUpClass
    {
        public bool IdSpecialCharater(String id)
        {
            string str = @"[~!@\#$%^&*\()\=+|\\/:;?""<>'가-힣]";
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(str);
            return rex.IsMatch(id);
        }
    }
}

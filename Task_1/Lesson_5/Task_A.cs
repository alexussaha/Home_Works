using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Login_A
    {
        string login;

        public void Login(string login)
        {
            this.login = login;
        }

        public bool TheFistSymbolIsNumber()
        {
            return Char.IsDigit(login[0]); 
        }

        public bool IsTheLoginLengthFalse()
        {
            return login.Length > 1 && login.Length < 11 ? false : true;
        }

        public bool IfTheLoginContainsForbiddenSymbols()
        {
            for(int i = 0; i < login.Length; i++)
            {
                if (!Char.IsLetterOrDigit(login[i])) return true;
                
            }
            return false;
        }

        public bool IfTheLoginIsRight()
        {
            bool testA = IsTheLoginLengthFalse(), testB = TheFistSymbolIsNumber(), testC = IfTheLoginContainsForbiddenSymbols();
            return !(!testA & !testB & !testC);

        }
    }
}

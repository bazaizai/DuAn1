using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PL.Utilities
{
    public class CheckValidate
    {
        public static bool CheckEmpty(string Msg) => string.IsNullOrEmpty(Msg.Trim());
        public static bool InputIsOnlyNumber(string Msg) => int.TryParse(Msg.Trim(), out int x);
    }
}

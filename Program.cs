using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StoreProcedureWithADO_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAction user = UserAction.GetUserAction();
            user.Perform();
            ReadLine();
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StoreProcedureWithADO_003
{
    internal class UserAction
    {
        Employee employee = null;

        private static UserAction useraction;
        private UserAction() { }
        public static UserAction GetUserAction()
        {
            if(useraction == null)
            {
                useraction = new UserAction();
            }
            return useraction;
        }

        public enum Option
        {
            Create = 1,
            Insert = 2,
            Update = 3,
            Delete = 4,
            Exit = 5
        };

        public void Perform()
        {
            Option options;
            do
            {
                WriteLine(DisplayConstant.INFO);
                WriteLine();
                WriteLine(DisplayConstant.MENU_START);
                WriteLine(DisplayConstant.MENU_CREATE);
                WriteLine(DisplayConstant.MENU_INSERT_EMPLOYEE);
                WriteLine(DisplayConstant.MENU_UPDATE_EMPLOYEE);
                WriteLine(DisplayConstant.MENU_DELETE_EMPLOYEE);
                WriteLine(DisplayConstant.MENU_EXIT_PROGRAM);
                WriteLine();
                WriteLine(DisplayConstant.END_OF_PAGE_MESSAGE);

                Enum.TryParse(ReadLine(), out options);

                switch (options)
                {
                    case Option.Create:
                        {
                            employee = employee ?? new Employee();
                            break;
                        }
                    case Option.Insert:
                        {
                            if (employee != null)
                            {
                                employee.InsertEmployee();
                            }
                            break;
                        }
                    case Option.Update:
                        {
                            if (employee != null)
                            {
                                employee.UpdateEmployee();
                            }
                            break;
                        }
                    case Option.Delete:
                        {
                            if (employee != null)
                            {
                                employee.DeleteEmployee();
                            }
                            break;
                        }
                    case Option.Exit:
                        {
                            break;
                        }
                    default:
                        {
                            WriteLine(DisplayConstant.MENU_DONT_FUNCTION);
                            break;
                        }
                }
            }
            while (options != Option.Exit);
        }
    }
}

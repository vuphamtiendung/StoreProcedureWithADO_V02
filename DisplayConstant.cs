using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StoreProcedureWithADO_003
{
    internal static class DisplayConstant
    {
        public const string INFO = "=========================== Employee Management ======================";

        public const string NAME = "Input name employee: ";
        public const string ID = "Input id employee: ";
        public const string EMAIL = "Input email employee: ";
        public const string MOBILE = "Input mobile employee: ";

        public const string DELETE_ID = "Input Id to delete employee: ";

        public const string INSERT_SUCCESS = "Insert Successs";
        public const string UPDATE_SUCCESS = "Update Succeess";
        public const string DELETE_SUCCESS = "Delete Success";

        public const string WARNING = "Has been errored! {0}";

        #region menu
        public const string MENU_START = "Please choise a function";
        public const string MENU_CREATE = "1. Create an employee";
        public const string MENU_INSERT_EMPLOYEE = "2. Insert an employee";
        public const string MENU_UPDATE_EMPLOYEE = "3. Update an employee";
        public const string MENU_DELETE_EMPLOYEE = "4. Delete an employee";
        public const string MENU_EXIT_PROGRAM = "5. Exit";
        #endregion endmenu

        public const string MENU_DONT_FUNCTION = " System don't support this function";

        public const string END_OF_PAGE_MESSAGE = "============================= End of page message ===========================";
    }
}

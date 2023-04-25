using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFinance_Calculator.utils
{
    class CheckIfNumeric
    {

        static bool CheckForNumeric(char ch)
        {
            //allow only numbers and a decimal point and backspace key
            int keyInt = (int)ch;
            if ((keyInt < 48 || keyInt > 57) && keyInt != 46 && keyInt != 8)
                return false;
            else
                return true;
        }
        
        public void Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only numbers and a decimal point and backspace key
            if (CheckForNumeric(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}

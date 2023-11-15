using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace vlute_course_manager.classes
{
    internal class Utils
    {
        public string checkNewPasswordSecure(string password)
        {
            if (password.Length == 0) 
                return "Vui lòng nhập mật khẩu!";

            if (password.Length < 8) 
                return "Vui lòng nhập mật khẩu chứa ít nhất 8 ký tự!";

            if (password.Length > 40)
                return "Mật khẩu chỉ cho phép tối đa 40 ký tự!";

            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,40}$");

            if (!regex.IsMatch(password))
                return "Phải chứ ký tự thường, HOA, chữ số và ký tự đặc biệt!";

            return null;
        }
    }
}

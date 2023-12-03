using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace vlute_course_manager.classes
{
    internal class Utils
    {
        public readonly string PROJECT_PATH;
        public readonly string PROJECT_PATH_FORMAT;
        public readonly string ASSET_PATH;
        public readonly string DEFAULT_COURSE_ICON_PATH;

        public Utils()
        {
            List<string> projectPathList = Directory.GetCurrentDirectory().Split('\\').ToList();
            projectPathList.RemoveAt(projectPathList.Count - 1);
            projectPathList.RemoveAt(projectPathList.Count - 1);

            this.PROJECT_PATH = String.Join(@"/", projectPathList.ToArray());
            this.PROJECT_PATH_FORMAT = String.Join(@"//", projectPathList.ToArray());
            this.ASSET_PATH = this.PROJECT_PATH + "/assets";
            this.DEFAULT_COURSE_ICON_PATH = this.ASSET_PATH + "/images/formHome/courseIcon.png";
        }

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

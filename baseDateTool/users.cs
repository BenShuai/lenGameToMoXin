using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baseDateTool
{
    /// <summary>
    /// 账号信息类
    /// </summary>
    public class users
    {
        public string userId;//账号
        public string userPassword;//密码
        public string userName;//真实姓名

        public users() { }

        public users(string userIds, string userPasswords, string userNames)
        {
            this.userId = userIds;
            this.userName = userNames;
            this.userPassword = userPasswords;
        }
    }
}

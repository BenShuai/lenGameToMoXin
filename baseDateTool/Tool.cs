using System.IO;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace baseDateTool
{
    public class Tool
    {
        /// <summary>
        /// 判断保存数据库文件的文件夹是否存在，不存在则创建
        /// </summary>
        /// <param name="Paths"></param>
        public static void FillToBase()
        {
            if (!Directory.Exists(@"lib/com.lenleicool.dateBase/com.lztr/"))
            {
                Directory.CreateDirectory(@"lib/com.lenleicool.dateBase/com.lztr/");
            }
        }
        /// <summary>
        /// 普通鼠标
        /// </summary>
        public static Cursor myCursor;
        /// <summary>
        /// 悬停鼠标
        /// </summary>
        public static Cursor myCursor1;
        /// <summary>
        /// 输入鼠标
        /// </summary>
        public static Cursor myCursor2;
        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static users user;
        /// <summary>
        /// 当前用户 使用 的角色
        /// </summary>
        public static gameEr gameer;
        /// <summary>
        /// 当前用户的所有游戏角色
        /// </summary>
        public static List<gameEr> gameers;
        /// <summary>
        /// 全文确定类型判断
        /// </summary>
        public static Boolean flag = false;
        /// <summary>
        /// 当前角色下的装备列表
        /// </summary>
        public static List<zhuangBei> ZhuangBeiList;


        /// <summary>
        /// 返回随机数
        /// </summary>
        /// <param name="str">随机的最小数</param>
        /// <param name="stop">随机的最大数</param>
        /// <returns></returns>
        public static int randomNum(int str,int stop)
        {
            Random ran = new Random();
            return ran.Next(str, stop);
        }
        /// <summary>
        /// 加密游戏角色
        /// </summary>
        /// <param name="gameer"></param>
        /// <returns></returns>
        public static gameEr GameErJiaMi(gameEr gameer)
        {
            //gameer.userId = StringPassWord.EncryptDES(gameer.userId, "aaaaaaaa");
            gameer.niName = StringPassWord.EncryptDES(gameer.niName, "aaaaaaaa");
            gameer.playerType = StringPassWord.EncryptDES(gameer.playerType, "aaaaaaaa");
            return gameer;
        }


        /// <summary>
        /// 解密游戏角色
        /// </summary>
        /// <param name="gameer"></param>
        /// <returns></returns>
        public static gameEr GameErOpen(gameEr gameer)
        {
            gameer.niName = StringPassWord.DecryptDES(gameer.niName, "aaaaaaaa");
            gameer.playerType = StringPassWord.DecryptDES(gameer.playerType, "aaaaaaaa");
            return gameer;
        }

        /// <summary>
        /// 解密用户信息
        /// </summary>
        /// <param name="gameer"></param>
        /// <returns></returns>
        public static users UserOpen(users us)
        {
            us.userPassword = StringPassWord.DecryptDES(us.userPassword, "aaaaaaaa");
            us.userName = StringPassWord.DecryptDES(us.userName, "aaaaaaaa");
            return us;
        }

    }
}

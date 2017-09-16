using System.Data;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace baseDateTool
{
    /// <summary>
    /// 数据库操作的类
    /// </summary>
    public class Data_len
    {
        //实例化本地数据库对象(数据库的名称为：LenDate)
        public static DataSet db = new DataSet("LenDate");

        /// <summary>
        /// 读取数据
        /// </summary>
        public static void RedData()
        {
            db.ReadXml(@"lib/com.lenleicool.dateBase/com.lztr/configBaseAction.xml");
        }
        /// <summary>
        /// 保存数据到文件
        /// </summary>
        public static void WriData()
        {
            db.WriteXml(@"lib/com.lenleicool.dateBase/com.lztr/configBaseAction.xml");
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="us">用户</param>
        /// <returns></returns>
        public static users login(users us, Label l)
        {
            users loginUser = null;
            try
            {
                db = new DataSet("LenDate");
                RedData();//读取数据
                DataTable usersTable = db.Tables["users"];
                usersTable.CaseSensitive = true;//设置表中的字符串区分大小写

                //加密账号和密码
                string userId = StringPassWord.EncryptDES(us.userId, "aaaaaaaa");//返回加密后的字符串
                string pass = StringPassWord.EncryptDES(us.userPassword, "aaaaaaaa");//返回加密后的字符串

                DataRow[] usList = usersTable.Select("userId = '" + userId + "' and userPassword='" + pass + "'");
                if (usList.Length > 0)
                {
                    loginUser = new users(usList[0][0].ToString(), usList[0][1].ToString(), usList[0][2].ToString());
                    loginUser = Tool.UserOpen(loginUser);
                }
            }
            catch
            {
                l.Text = "您未注册，请先注册";
                return null;
            }
            return loginUser;
        }
        /// <summary>
        /// 判断账号是否可以注册
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static Boolean qureyUserId(String userId)
        {
            try
            {
                db = new DataSet("LenDate");
                RedData();//读取数据
                DataTable usersTable = db.Tables["users"];
                usersTable.CaseSensitive = true;//设置表中的字符串区分大小写

                string userIds = StringPassWord.EncryptDES(userId, "aaaaaaaa");//返回加密后的字符串

                DataRow[] usList = usersTable.Select("userId = '" + userIds + "'");
                if (usList.Length > 0)
                {
                    return false;
                }
            }
            catch
            {
                return true;
            }
            return true;
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        public static void RegBase(users userd)
        {
            DataTable dt;
            try
            {
                db = new DataSet("LenDate");
                RedData();//读取数据
            }
            catch { }
            //如果数据库没有表，则创建表
            if (db.Tables.Count == 0)
            {
                //创建用户表
                dt = new DataTable("users");
                //创建表的字段
                dt.Columns.Add("userId", System.Type.GetType("System.String"));
                dt.Columns.Add("userPassword", System.Type.GetType("System.String"));
                dt.Columns.Add("userName", System.Type.GetType("System.String"));
                //将创建的表添加进数据库
                db.Tables.Add(dt);
            }
            else//数据库中有表
            {
                DataTable dtBs = new DataTable("users");
                if (!db.Tables.Contains(dtBs.TableName))
                {
                    //创建表的字段
                    dtBs.Columns.Add("userId", System.Type.GetType("System.String"));
                    dtBs.Columns.Add("userPassword", System.Type.GetType("System.String"));
                    dtBs.Columns.Add("userName", System.Type.GetType("System.String"));
                    db.Tables.Add(dtBs);
                }
                dt = db.Tables["users"];
            }
            //创建数据行   插入数据
            DataRow dr = dt.NewRow();
            //将用户信息加密
            string uid = StringPassWord.EncryptDES(userd.userId, "aaaaaaaa");//返回加密后的字符串
            string upa = StringPassWord.EncryptDES(userd.userPassword, "aaaaaaaa");//返回加密后的字符串
            string una = StringPassWord.EncryptDES(userd.userName, "aaaaaaaa");//返回加密后的字符串
            //将加密后的信息保存到数据行
            dr["userId"] = uid;
            dr["userPassword"] = upa;
            dr["userName"] = una;
            //将数据行保存到表
            dt.Rows.Add(dr);
            WriData();//将数据保存到文件
        }
        /// <summary>
        /// 返回登录账户的所有游戏角色
        /// </summary>
        /// <param name="usId"></param>
        /// <returns></returns>
        public static List<gameEr> queryGameEr(string usId)
        {
            List<gameEr> gameErListBase = null;
            DataTable dtBs = new DataTable("gameEr");
            if (!db.Tables.Contains(dtBs.TableName))
            {
                //创建表的字段
                dtBs.Columns.Add("userId", System.Type.GetType("System.String"));
                dtBs.Columns.Add("niName", System.Type.GetType("System.String"));
                dtBs.Columns.Add("playerType", System.Type.GetType("System.String"));
                dtBs.Columns.Add("grade", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("experience", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("HouPi", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("MoPi", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("attack", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("defense", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("thump", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("ZXC", System.Type.GetType("System.Int32"));
                dtBs.Columns.Add("qi", System.Type.GetType("System.Int32"));
                db.Tables.Add(dtBs);
                return null;
            }
            else
            {
                DataTable gameErTab = db.Tables["gameEr"];
                DataRow[] gameErList = gameErTab.Select("userId = '" + usId + "'");
                if (gameErList.Length > 0)
                {
                    gameErListBase = new List<gameEr>();
                    for (int i = 0; i < gameErList.Length; i++)
                    {
                        gameEr gameer = new gameEr(gameErList[i]["userId"].ToString(), gameErList[i]["niName"].ToString(),
                            gameErList[i]["playerType"].ToString(), Int32.Parse(gameErList[i]["grade"].ToString()),
                            Int32.Parse(gameErList[i]["experience"].ToString()), Int32.Parse(gameErList[i]["HouPi"].ToString()),
                            Int32.Parse(gameErList[i]["MoPi"].ToString()), Int32.Parse(gameErList[i]["attack"].ToString()),
                            Int32.Parse(gameErList[i]["defense"].ToString()), Int32.Parse(gameErList[i]["thump"].ToString()),
                            Int32.Parse(gameErList[i]["ZXC"].ToString()), Int32.Parse(gameErList[i]["qi"].ToString()));
                        //解密游戏角色
                        gameer=Tool.GameErOpen(gameer);
                        gameErListBase.Add(gameer);
                    }
                }
            }
            return gameErListBase;
        }
        /// <summary>
        /// 将用户创建的游戏角色保存进文件
        /// </summary>
        /// <param name="gameer"></param>
        public static void CreateGameEr(gameEr gameer)
        {
            gameEr gameEres=Tool.GameErJiaMi(gameer);
            DataTable gameErTab = db.Tables["gameEr"];
            //创建数据行，保存刚创建的游戏角色
            DataRow dr = gameErTab.NewRow();
            dr["userId"] = gameEres.userId;
            dr["niName"] = gameEres.niName;
            dr["playerType"] = gameEres.playerType;
            dr["grade"] = gameEres.grade;
            dr["experience"] = gameEres.experience;
            dr["HouPi"] = gameEres.HP;
            dr["MoPi"] = gameEres.MP;
            dr["attack"] = gameEres.attack;
            dr["defense"] = gameEres.defense;
            dr["thump"] = gameEres.thump;
            dr["ZXC"] = gameEres.ZXC;
            dr["qi"] = gameEres.qi;
            gameErTab.Rows.Add(dr);
            WriData();//将数据保存到文件
        }
        /// <summary>
        /// 判断当前角色昵称是否重复，重复的不可创建
        /// </summary>
        /// <param name="NiName"></param>
        /// <returns></returns>
        public static Boolean NiNameBaseTrue(string NiName)
        {
            DataTable gameErTab = db.Tables["gameEr"];
            NiName = StringPassWord.EncryptDES(NiName, "aaaaaaaa");
            //判断名字是否重复
            DataRow[] gameErList = gameErTab.Select("niName = '" + NiName + "'");
            if (gameErList != null)
            {
                if (gameErList.Length > 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="DelName"></param>
        public static void DelGameEr(string DelName)
        {
            DataTable gameErTab = db.Tables["gameEr"];
            DelName = StringPassWord.EncryptDES(DelName, "aaaaaaaa");
            DataRow[] gameErList = gameErTab.Select("niName = '" + DelName + "'");
            gameErTab.Rows.Remove(gameErList[0]);
            WriData();//将数据保存到文件
            Tool.gameers = queryGameEr(Tool.user.userId);
        }



        /// <summary>
        /// 返回游戏角色下的所有装备
        /// </summary>
        /// <param name="usId"></param>
        /// <returns></returns>
        public static List<zhuangBei> queryZhuangBei(string NiName)
        {
            List<zhuangBei> zhuangBeiListBase = null;
            DataTable dtBs = new DataTable("zhuangBei");
            if (!db.Tables.Contains(dtBs.TableName))
            {
                //创建表的字段
                dtBs.Columns.Add("niName", System.Type.GetType("System.String"));
                dtBs.Columns.Add("wuName", System.Type.GetType("System.String"));
                dtBs.Columns.Add("nums", System.Type.GetType("System.Int32"));
                db.Tables.Add(dtBs);
                return null;
            }
            else
            {
                DataTable zhuangBeiTab = db.Tables["zhuangBei"];
                DataRow[] zhuangBeiList = zhuangBeiTab.Select("niName = '" + NiName + "'");
                if (zhuangBeiList.Length > 0)
                {
                    zhuangBeiListBase = new List<zhuangBei>();
                    for (int i = 0; i < zhuangBeiList.Length; i++)
                    {
                        zhuangBei zhuangBei = new zhuangBei(zhuangBeiList[i]["niName"].ToString(), zhuangBeiList[i]["wuName"].ToString(), Int32.Parse(zhuangBeiList[i]["nums"].ToString()));
                        zhuangBeiListBase.Add(zhuangBei);
                    }
                }
            }
            return zhuangBeiListBase;
        }
    }
}

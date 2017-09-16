using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baseDateTool
{
    /// <summary>
    /// 游戏角色信息类
    /// </summary>
    public class gameEr
    {
        /// <summary>
        /// 对应账号
        /// </summary>
        public string userId;
        /// <summary>
        /// 昵称
        /// </summary>
        public string niName;
        /// <summary>
        /// 游戏角色(nv1   nv2    nan1    nan2)
        /// </summary>
        public string playerType;
        /// <summary>
        /// 等级
        /// </summary>
        public int grade;
        /// <summary>
        /// 经验
        /// </summary>
        public int experience;
        public int HP;
        public int MP;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int attack;
        /// <summary>
        /// 防御力
        /// </summary>
        public int defense;
        /// <summary>
        /// 暴击率 ( 千分之 )
        /// </summary>
        public int thump;
        /// <summary>
        /// 必杀率 ( 千分之 )
        /// </summary>
        public int ZXC;
        /// <summary>
        /// 怒气值 ( 100为满 )
        /// </summary>
        public int qi;

        public gameEr() { }

        public gameEr(string userIds, string niNames, string playerTypes, int grades, int experiences, int HPs, int MPs, int attacks, int defenses, int thumps, int ZXCs, int qis)
        {
            this.userId = userIds;
            this.niName = niNames;
            this.playerType = playerTypes;
            this.grade = grades;
            this.experience = experiences;
            this.HP = HPs;
            this.MP = MPs;
            this.attack = attacks;
            this.defense = defenses;
            this.thump = thumps;
            this.ZXC = ZXCs;
            this.qi = qis;
        }




    }
}

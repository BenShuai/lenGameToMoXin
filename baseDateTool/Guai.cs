using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using baseDateTool;
using System.Media;

namespace baseDateTool
{
    /// <summary>
    /// 怪物信息类
    /// </summary>
    public class Guai
    {
        public String guaiName;//怪物名称
        public int dengji;//怪物等级
        public int xue;//怪物血量
        public int gong;//怪物攻击力
        public int fang;//怪物防御力
        public int dazhao;//释放大招的几率（最小：0；最大100）
        public int dazhaosha;//怪物释放的大招的杀伤力

        public Guai() { }//无参数的构造方法


        public Guai(String guaiNames, int dengjis, int xues, int gongs, int fangs, int dazhaos, int dazhaoshas)
        {//有参数的构造方法
            guaiName = guaiNames;
            dengji = dengjis;
            xue = xues;
            gong = gongs;
            fang = fangs;
            dazhao = dazhaos;
            dazhaosha = dazhaoshas;
        }
    }
}

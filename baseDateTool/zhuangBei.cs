using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baseDateTool
{
    /// <summary>
    /// 装备类 武器盔甲等
    /// </summary>
    public class zhuangBei
    {
        /// <summary>
        /// 对应昵称
        /// </summary>
        public string niName;
        /// <summary>
        /// 装备名称
        /// </summary>
        public string wuName;
        /// <summary>
        /// 数量
        /// </summary>
        public int nums;

        public zhuangBei() { }

        public zhuangBei(string niNames, string wuNames, int nums)
        {
            this.niName = niNames;
            this.wuName = wuNames;
            this.nums = nums;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Factory
{
    /// <summary>
    /// 主机类
    /// </summary>
    public class GameConsole
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Amount { get; set; }



        public virtual string ShowProducts()
        {
            return string.Format("生产型号为{1}的{0}数量为{2}", this.Name, this.Type, this.Amount);
        }

    }

}

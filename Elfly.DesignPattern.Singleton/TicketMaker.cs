using System;
using System.Collections.Generic;
using System.Text;

namespace Elfly.DesignPattern.Singleton
{
    /// <summary>
    /// 票根生成器
    /// </summary>
    public class TicketMaker
    {
        private int ticket = 1000;

        /// <summary>
        /// 静态的TicketMack
        /// </summary>
        private static TicketMaker _TicketMacker = null;

        private static object obj = new object();
        /// <summary>
        /// 私有化构造函数，预防被初始化
        /// </summary>
        private TicketMaker()
        {

        }

        /// <summary>
        /// 获取实例的方法
        /// </summary>
        /// <returns>返回实例</returns>
        public static TicketMaker GetInstance()
        {
            lock (obj)
            {
                if (_TicketMacker == null)
                {
                    _TicketMacker = new TicketMaker();
                }
            }
            return _TicketMacker;
        }

        /// <summary>
        /// 累加器方法
        /// </summary>
        /// <returns>增加后的值</returns>
        public int GetNextTickerNumber()
        {
            return ticket++;
        }
    }
}

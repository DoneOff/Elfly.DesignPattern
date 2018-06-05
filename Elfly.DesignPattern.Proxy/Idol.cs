using System;
using System.Collections.Generic;
using System.Text;

namespace Elfly.DesignPattern.Proxy
{
    /// <summary>
    /// 真实的偶像
    /// </summary>
    [Module("Idol")]
    public class Idol : Iidol
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        public Idol(string name)
        {
            this.Name = name;
        }

        [Method("Dance")]
        public string Dance()
        {
            return this.Name + "正在跳舞";
        }

        [Method("Sing")]
        public string Sing()
        {
            return this.Name + "正在唱歌";

        }

        [Method("Smile")]
        public string Smile()
        {
            return this.Name + "正在假笑";
        }
    }
}

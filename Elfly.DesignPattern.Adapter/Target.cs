using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Adapter
{
    /// <summary>
    /// 目标类
    /// </summary>
    public abstract class Target
    {
        public virtual void SayHello()
        {
            Console.WriteLine("Target: Say Hello !");
        }

        public virtual void SayGoodBye()
        {
            Console.WriteLine("Target: Say GoodBye !");
        }
    }
}

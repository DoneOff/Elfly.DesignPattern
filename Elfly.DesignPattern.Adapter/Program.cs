using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //直接执行，需要依赖于具体的适配器
            Invoke();

            //通过反射执行，不依赖于具体的适配器
            ReflecInvoke();

            Console.ReadLine();
        }

        public static void Invoke()
        {
            //可以通过新增适配器类，进行扩展
            Adaptee adaptee = new Adaptee();
            //目标类
            Target target = new Adapter(adaptee);

            //调用Say Hello
            target.SayHello();
            //调用Say GoodBye
            target.SayGoodBye();
        }

        public static void ReflecInvoke()
        {
            //可通过配置获取类型全名
            Type type = Type.GetType("Elfly.DesignPattern.Adapter.Adapter");

            if (type != null)
            {
                Target target = (Target)Activator.CreateInstance(type, true);

                //调用Say Hello
                target.SayHello();

                //调用Say GoodBye
                target.SayGoodBye();
            }
        }
    }
}

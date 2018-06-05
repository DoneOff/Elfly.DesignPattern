using System;

namespace Elfly.DesignPattern.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //直接代理执行
            //Invoke();

            //动态代理执行
            DynamicInvoke();
            Console.ReadLine();
        }

        /// <summary>
        /// 直接通过代理执行方法
        /// </summary>
        private static void Invoke()
        {
            IdolProxy idolProxy = new IdolProxy("板野友美");
            Console.WriteLine(idolProxy.Dance());
            Console.WriteLine(idolProxy.Sing());
            Console.WriteLine(idolProxy.Smile());
        }

        /// <summary>
        /// 动态代理执行方法
        /// </summary>
        private static void DynamicInvoke()
        {
            IdolProxy idolProxy = new IdolProxy();
            Console.WriteLine(idolProxy.invoke("Idol", "Dance", new object[] { }));
            Console.WriteLine(idolProxy.invoke("Idol", "Smile", new object[] { }));
        }
    }
}

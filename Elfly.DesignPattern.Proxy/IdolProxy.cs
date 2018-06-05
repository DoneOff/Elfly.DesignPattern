using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Elfly.DesignPattern.Proxy
{
    /// <summary>
    /// 代理类
    /// 同时实现了动态代理和静态代理两种方式
    /// </summary>
    public class IdolProxy : Iidol, Iinvoker
    {

        #region 动态代理

        /// <summary>
        /// 被代理的模块
        /// </summary>
        private Dictionary<string, object> Modules = new Dictionary<string, object>();

        /// <summary>
        /// 被代理的模块的方法信息
        /// </summary>
        private Dictionary<string, MethodInfo> Methods = new Dictionary<string, MethodInfo>();

        /// <summary>
        /// 代理类的默认无参构造器
        /// 将要代理的类和方法在初始化时缓存
        /// </summary>
        public IdolProxy()
        {
            //获取运行中的程序集信息
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var t in types)
            {
                if (typeof(Iidol).IsAssignableFrom(t))
                {
                    ModuleAttribute moduleAttribute = (ModuleAttribute)Attribute.GetCustomAttribute(t, typeof(ModuleAttribute));
                    if (moduleAttribute != null)
                    {
                        //需要被代理的类
                        ConstructorInfo constructorInfo = t.GetConstructor(new Type[] { typeof(string) });
                        object module = constructorInfo.Invoke(new object[] { moduleAttribute.moduleName });
                        Modules.Add(t.Name, module);
                    }
                    var methods = t.GetMethods();
                    foreach (var method in methods)
                    {
                        //需要被代理的方法
                        MethodAttribute methodAttribute = (MethodAttribute)Attribute.GetCustomAttribute(method, typeof(MethodAttribute));
                        if (methodAttribute != null)
                        {
                            Methods.Add(t.Name + "." + method.Name, method);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 利用反射机制动态去调用被代理的模块方法
        /// </summary>
        /// <param name="className">模块名称</param>
        /// <param name="methodName">调用的方法</param>
        /// <param name="parameters">方法传递参数</param>
        /// <returns>执行结果</returns>
        public object invoke(string className, string methodName, object[] parameters)
        {
            string key = className + "." + methodName;
            if (Methods.ContainsKey(key))
            {
                MethodInfo method = Methods[key];
                return method.Invoke(Modules[className], parameters);
            }
            return null;
        }
        #endregion


        #region 静态代理

        /// <summary>
        /// 静态代理的对象
        /// </summary>
        public Iidol Idol { get; set; }

        public IdolProxy(string moduleName)
        {
            this.Idol = new Idol(moduleName);
        }

        public string Dance()
        {
            return Idol.Dance();
        }

        public string Sing()
        {
            return Idol.Sing();
        }

        public string Smile()
        {
            return Idol.Smile();

        }

        #endregion
    }
}

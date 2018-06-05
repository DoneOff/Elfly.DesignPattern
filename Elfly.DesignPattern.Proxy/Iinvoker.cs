using System;
using System.Collections.Generic;
using System.Text;

namespace Elfly.DesignPattern.Proxy
{
    /// <summary>
    /// 执行接口
    /// </summary>
    public interface Iinvoker
    {
        /// <summary>
        /// 调用被代理的模块方法
        /// </summary>
        /// <param name="className">模块名称</param>
        /// <param name="methodName">调用的方法</param>
        /// <param name="parameters">方法传递参数</param>
        /// <returns>执行结果</returns>
        object invoke(string className, string methodName, object[] parameters);
    }
}

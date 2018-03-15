using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Factory
{
    /// <summary>
    /// 主机生产厂商
    /// </summary>
    public class GameConsoleFactory
    {
        /// <summary>
        /// 生产游戏机
        /// </summary>
        /// <param name="company">游戏机厂商</param>
        /// <returns></returns>
        public GameConsole CreateGameConsole(CompanyEnum company)
        {
            GameConsole gameConsole = null;
            switch (company)
            {
                case CompanyEnum.Sony:
                    gameConsole = new Sony();
                    break;
                case CompanyEnum.Nintendo:
                    gameConsole = new Nintendo();
                    break;
                case CompanyEnum.MicroSoft:
                    gameConsole = new MicroSoft();
                    break;
            }
            return gameConsole;
        }
    }
}

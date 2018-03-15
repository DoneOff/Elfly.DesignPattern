using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elfly.DesignPattern.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            GameConsoleFactory gameConsoleFactory = new GameConsoleFactory();
            while (true)
            {
                Console.WriteLine("请选择要生产的主机编码：");
                Console.WriteLine("1,PS4");
                Console.WriteLine("2,NS");
                Console.WriteLine("3，Xbox");
                string str = Console.ReadLine();
                if (str == "exit") break;
                int key = 0;

                if (int.TryParse(str, out key) && key < 4)
                {
                    GameConsole gameConsole = gameConsoleFactory.CreateGameConsole((CompanyEnum)key);
                    Console.WriteLine(gameConsole.ShowProducts());
                }
            }

        }
    }
}

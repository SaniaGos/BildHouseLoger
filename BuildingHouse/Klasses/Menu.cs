using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLoger;

namespace BuildingHouse.Klasses
{
    class Menu
    {
        public static void MyMenu(Project project)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(60, 10); Console.Write($"Menu");
            Console.SetCursorPosition(55, 11); Console.Write("1.Write report");
            Console.SetCursorPosition(55, 12); Console.Write("2.Build Basement");
            Console.SetCursorPosition(55, 13); Console.Write("3.Build Wall");
            Console.SetCursorPosition(55, 14); Console.Write("4.Build Roof");
            Console.SetCursorPosition(55, 15); Console.Write("5.Build Window");
            Console.SetCursorPosition(55, 16); Console.Write("6.Build Door");
            Console.SetCursorPosition(55, 17); Console.Write("7.Hire an employee");
            Console.SetCursorPosition(55, 18); Console.Write("8.Dismiss the employee");
            Console.SetCursorPosition(55, 19); Console.Write("Esc.Close program");
            Console.SetCursorPosition(55, 21); Console.Write("To Continue press any key");
            Team team = new Team(new House(project));
            while (true)
            {
                Console.SetCursorPosition(55, 22);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        Loger.WriteLog("Out of program");
                        return;
                    case ConsoleKey.D1:
                        team.TeamLeader.DoWork();
                        break;
                    case ConsoleKey.D2:
                        team.BuildBasement();
                        break;
                    case ConsoleKey.D3:
                        team.BuildWalls();
                        break;
                    case ConsoleKey.D4:
                        team.BuildRoof();
                        break;
                    case ConsoleKey.D5:
                        team.BuildWindows();
                        break;
                    case ConsoleKey.D6:
                        team.BuildDoor();
                        break;
                    case ConsoleKey.D7:
                        team.HireWorkers();
                        break;
                    case ConsoleKey.D8:
                        team.LayOffWorkers();
                        break;
                    case ConsoleKey.NumPad1:
                        team.TeamLeader.DoWork();
                        break;
                    case ConsoleKey.NumPad2:
                        team.BuildBasement();
                        break;
                    case ConsoleKey.NumPad3:
                        team.BuildWalls();
                        break;
                    case ConsoleKey.NumPad4:
                        team.BuildRoof();
                        break;
                    case ConsoleKey.NumPad5:
                        team.BuildWindows();
                        break;
                    case ConsoleKey.NumPad6:
                        team.BuildDoor();
                        break;
                    case ConsoleKey.NumPad7:
                        team.HireWorkers();
                        break;
                    case ConsoleKey.NumPad8:
                        team.LayOffWorkers();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

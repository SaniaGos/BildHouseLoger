using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuildingHouse.Interfaces;
using MyLoger;


namespace BuildingHouse.Klasses
{
    class TeamLeader : IWorker
    {
        private House house;
        public TeamLeader(House house)
        {
            this.house = house;
        }
        public void DoWork()
        {
            Report();
        }
        private void Report()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(60, 1); Console.WriteLine($"Report");
            Loger.WriteLog($"Report");
            
            Console.SetCursorPosition(55, 2); Console.WriteLine($"Basement is  {house.Documentation.ActWorkPerformed.BasementFinish}  ");
            Loger.WriteLog($"Basement is  {house.Documentation.ActWorkPerformed.BasementFinish}  ");

            Console.SetCursorPosition(55, 3); Console.WriteLine($"Walls    is  {house.Documentation.ActWorkPerformed.WallsFinish}  ");
            Loger.WriteLog($"Walls    is  {house.Documentation.ActWorkPerformed.WallsFinish}  ");

            Console.SetCursorPosition(55, 4); Console.WriteLine($"Roof     is  {house.Documentation.ActWorkPerformed.RoofFinish}  ");
            Loger.WriteLog($"Roof     is  {house.Documentation.ActWorkPerformed.RoofFinish}  ");

            Console.SetCursorPosition(55, 5); Console.WriteLine($"Door     is  {house.Documentation.ActWorkPerformed.DoorFinish}  ");
            Loger.WriteLog($"Door     is  {house.Documentation.ActWorkPerformed.DoorFinish}  ");

            Console.SetCursorPosition(55, 6); Console.WriteLine($"Windows  is  {house.Documentation.ActWorkPerformed.WindowFinish}  ");
            Loger.WriteLog($"Windows  is  {house.Documentation.ActWorkPerformed.WindowFinish}  ");

            Console.SetCursorPosition(55, 7); Console.WriteLine($"House    is  {house.Documentation.ActWorkPerformed.HouseIsFinish()}  ");
            Loger.WriteLog($"House    is  {house.Documentation.ActWorkPerformed.HouseIsFinish()}  ");
            Loger.WriteLog("\n");
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }
    }
}
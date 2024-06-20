using System;
using HelloWorld.Models;

namespace HelloWorld
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
          Computer myComputer = new Computer(){
                CPUCores = 4,
                HasLTE = false,
                HasWifi = true,
                Motherboard = "Asus",
                Price = 954.87m,
                ReleaseDate = DateTime.Now,
                VideoCard = "Nvidia"
          };

          Console.WriteLine($"My computer has {myComputer.CPUCores} CPU cores, {myComputer.Motherboard} motherboard, {myComputer.VideoCard} video card, {myComputer.Price} price, {myComputer.ReleaseDate} release date, {myComputer.HasLTE} LTE, {myComputer.HasWifi} Wifi");

        }
    }
}
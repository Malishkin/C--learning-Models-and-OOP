using System;

namespace HelloWorld
{
    public class Computer
    {

        public  Computer(){
       
     }
           public string Motherboard { get; set; } = "";
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = "";
   
   
    }
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
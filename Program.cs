using System;

namespace HelloWorld
{
    public class Computer
    {

        public  Computer(){
        if(VideoCard == null){
            VideoCard = "";
        }
        if(Motherboard == null){
            Motherboard = "";
        }
     }
        // private string _motherboard;
        public string Motherboard { get; set; }
        public int CPUCores { get; set; }

        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }

        public DateTime ReleaseDate { get; set; }

       public decimal Price { get; set; }

       
       public string VideoCard { get; set; }

   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Computer myComputer = new Computer(){
                CPUCores = 4,
                HasLTE = true,
                HasWifi = true,
                Motherboard = "Asus",
                Price = 954.87m,
                ReleaseDate = DateTime.Now,
                VideoCard = "Nvidia"
          };

        }
    }
}
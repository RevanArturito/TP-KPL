// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Contracts;


internal class Program
{
    class random
    {
        public int idRandom()
        {
            Random id = new Random();
            return id.Next(10000, 99999);
        }
    }
    public class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            random random = new random();
            this.title = title;
            playCount = 0;
            id = random.idRandom();

        }

        public void IncreasePlayCount(int input)
        {
            this.playCount += input;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"PlayCount : {playCount}");
        }
    }
    public static void Main(String[] args)
    {
        SayaTubeVideo objVideo = new SayaTubeVideo("Tutorial Design By Contract – Cokorda Arturito Revan Putra Diarta ");
        objVideo.IncreasePlayCount(5);
        objVideo.PrintVideoDetails();
    }

}


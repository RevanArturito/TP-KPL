// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Contracts;



internal class Program
{   
    // membuat class random 
    class random
    {
        // method untuk membuat 5 digit angka random yang akan di assign 
        // pada variabel id
        public int idRandom()
        {
            Random id = new Random();
            return id.Next(10000, 99999);
        }
    }

    // membuat class SayaTubeVideo
    public class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;


        // konstruktor dari class dengan 1 parameter string sebagi input
        // yang akan di assign pada variable title
        public SayaTubeVideo(String title)
        {
            random random = new random();

            // debug assert sebagai pengecekan panjang title tidak boleh
            // melebihi 100 dan tidak boleh kosong atau null
            Debug.Assert(title.Length <= 100 && title != null);
            this.title = title;
            playCount = 0;
            id = random.idRandom();

        }

        // method increase play count untuk menambah attribut playcount
        // dengan input yang ada
        public void IncreasePlayCount(int input)
        {
            // debug assert sebagai pengecekan input tidak boleh melebihi 10000000
            Debug.Assert(input <= 10000000, "Jumlah playcount melebihi batas");
            try
            {
                // jika input sesuai dengan syarat diatas, maka akan dilakukan
                // penjumlahan dengan attribut playCount
                checked
                {
                    this.playCount += input;
                }
            }
            // jika input tidak sesuai maka akan menampilkan "Overflow"
            catch (OverflowException)  
            {
                Console.WriteLine("Overflow");
            }
        }

        // method untuk menampilkan id, title dan playcount
        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"PlayCount : {playCount}");
        }
    
    }
    public static void Main(String[] args)
    {
        SayaTubeVideo objVideo = new SayaTubeVideo("Tuorial Design By Contract – Cokorda Arturito Revan Putra Diarta ");
        objVideo.IncreasePlayCount(int.MaxValue);
        objVideo.PrintVideoDetails();
    }

}


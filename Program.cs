// See https://aka.ms/new-console-template for more information

internal class Program
{

    // membuat class DataGeneric dengan generic T
    public class DataGeneric<T>
    {
        private T data;

        // konstruktor dengan parameter data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // getData atau menampilkan data yang telah terisi
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah : {data}");
        }
    }

    // deklarasi class HaloGeneric
    public class HaloGeneric
    {

        // method SapaUser dengan parameter x 
        public void SapaUser<T>(T x)
        {
            //menampilkan data yang tersimpan pada x
            Console.WriteLine($"Halo {x}!");
        }       
    }

    private static void Main(string[] args)
    {
        //memanggil kembali class haloGeneric dan method sapaUser
        HaloGeneric generic = new HaloGeneric();
        Console.Write("Nama : ");
        String nama = Console.ReadLine();
        generic.SapaUser(nama);


        // memanggil kembali class DataGeneric dengan method printData
        Console.Write("NIM : ");
        String NIM = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(NIM);
        data.PrintData();
    }
}
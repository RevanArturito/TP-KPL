// See https://aka.ms/new-console-template for more information

internal class Program
{
    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah : {data}");
        }
    };

    private static void Main(string[] args)
    {
        Console.Write("NIM : ");
        String NIM = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(NIM);
        data.PrintData();
    }
};



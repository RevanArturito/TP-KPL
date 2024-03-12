// See https://aka.ms/new-console-template for more information

using System;

class kodePos {

    // deklarasi enum dengan nama daerah beserta kodePosnya.
    public enum enumKodePos
    {
      Batununggal = 40266,
      Kujangsari = 40287,
      Mengger = 40267,
      Wates = 40256,
      Cijaura = 40287,
      Jatisari = 40286,
      Margasari = 40286,
      Sekejati = 40286,
      Kebonwaru = 40272,
      Maleer = 40274,
      Samoja = 40273,
    }

    // mengembalikan nilai dari kodepos sesuai dengan daerah yang diinput dalam variable kodePos
    public static int getKodePos(enumKodePos kodePos)
    {
        return ((int)kodePos);
    }

    // Menampilkan nilai atau value kodepos dengan memanggil method
    // getKodePos dengan parameter nama daerah tertentu.
    public static void Main(string[] args)
    {
        enumKodePos kodePos = enumKodePos.Batununggal;
        Console.WriteLine($"{kodePos} = {getKodePos(kodePos)}");
    }
   
};


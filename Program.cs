// See https://aka.ms/new-console-template for more information

using System;
using static DoorMachine;

/*class kodePos {

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
   
};*/

public class DoorMachine
{
    // deklarasi enum doorstate
    public enum DoorState {TERKUNCI, TERBUKA};

    // deklarasi enum trigger
    public enum Trigger {BUKA_PINTU, KUNCI_PINTU};

    // deklarasi nilai awal dari pintu yaitu terkunci
    public DoorState currentDoorState = DoorState.TERKUNCI;


    // membuat class transisi untuk mengatur proses perubahan status pintu
    public class Transition
    {
        public DoorState StateAwal;
        public DoorState StateAkhir;
        public Trigger Trigger;

        public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
        {
            this.StateAwal = stateAwal;
            this.StateAkhir = stateAkhir;
            this.Trigger = trigger;
        }
    }


    // membuat daftar skenario yang mungkin terjadi disaat melakukan transisi
    Transition[] transisi =
    {
        new Transition(DoorState.TERBUKA, DoorState.TERKUNCI, Trigger.KUNCI_PINTU),
        new Transition(DoorState.TERKUNCI, DoorState.TERBUKA, Trigger.BUKA_PINTU),
        new Transition(DoorState.TERBUKA, DoorState.TERBUKA, Trigger.BUKA_PINTU),
        new Transition(DoorState.TERKUNCI, DoorState.TERKUNCI, Trigger.KUNCI_PINTU),
    };

    // fungsi untuk mengatur perubahan state pada pintu, di cek berdasarkan state awal 
    // dan trigger yang digunakan, akan dicek satu persatu dalam list transisi hingga
    // menemukan skenario yang cocok lalu mengembalikan state akhir
    public DoorState GetNextState(DoorState stateAwal, Trigger trigger)
    {
        DoorState stateAkhir = stateAwal;

        for (int i = 0; i < transisi.Length; i++)
        {
            Transition perubahan = transisi[i];
            if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
            {
                stateAkhir = perubahan.StateAkhir;
            }
        }
        return stateAkhir;
    }

 /*   public void ActivateTrigger(Trigger trigger)
    {
        currentDoorState = GetNextState(currentDoorState, trigger);

        Console.WriteLine($"State pintu sekarang adalah : {currentDoorState}");
    }*/

    public static void Main(String[] args)
    {
        DoorMachine objPintu = new DoorMachine();
        Console.WriteLine(objPintu.currentDoorState);

        // memanggil fungsi transisi untuk melakukan perubahan state pada pintu yang awalnya terkunci 
        // berubah menjadi terbuka dengan trigger BUKA_PINTU, dan ditutup kembali dengan trigger
        // KUNCI_PINTU yang membuat state awal pintu kembali terkunci
        Console.WriteLine($"State pintu sekarang adalah : {objPintu.GetNextState(objPintu.currentDoorState, DoorMachine.Trigger.BUKA_PINTU)}");
        Console.WriteLine($"State pintu sekarang adalah : {objPintu.GetNextState(objPintu.currentDoorState, DoorMachine.Trigger.KUNCI_PINTU)}");
        /*objPintu.ActivateTrigger(Trigger.BUKA_PINTU);
        objPintu.ActivateTrigger(Trigger.KUNCI_PINTU);*/
    }
} 


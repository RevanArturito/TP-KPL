﻿// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaUser<T>(T x)
    {
        Console.WriteLine($"Halo {x}!");
    }

    private static void Main(string[] args)
    {
        HaloGeneric generic = new HaloGeneric();
        generic.SapaUser("Repan");
    }
};

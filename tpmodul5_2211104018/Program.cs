﻿// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo User  {nama}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Budi");
        
    }
}
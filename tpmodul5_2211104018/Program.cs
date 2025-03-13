public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

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
        DataGeneric<string> dataGeneric = new DataGeneric<string>("2211104018");
        dataGeneric.PrintData();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Budi");
    }
}
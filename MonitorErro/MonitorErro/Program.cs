using MonitorErro.Class;

class Program
{
    public static void Main(string[] args)
    {
        var geradorDeExcepition = new GeradorDeException();

        for (int i = 0; i < 10; i++)
        {
            try
            {
                geradorDeExcepition.GetException();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Gerou o Erro: {e.GetType().ToString().Replace("System.","").PadRight(30)} - {e.Message}");
            }
        }

        Console.WriteLine($"\n\nFinalizou\n\n");
    }
}
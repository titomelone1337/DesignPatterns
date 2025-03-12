using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Singleton:");
        logClass.Instance.AddLog("Evento Login", "Sucesso");
        logClass.Instance.AddLog("Evento Registo", "Falha");

        List<LogEntry> logs = logClass.Instance.GetAllLogs();
        foreach (var log in logs)
        {
            Console.WriteLine(log.ToString());
        }

        Console.ReadKey();

    }
}

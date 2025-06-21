using System;

class Logger
{
    private static Logger? instance;

    private Logger()
    {
        Console.WriteLine("Logger created");
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log");

        Console.WriteLine("Same instance? " + Object.ReferenceEquals(logger1, logger2));
    }
}

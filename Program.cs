using System;

public class Logger
{
    private static Logger _instance; // Private static variable to hold the single instance

    // Private constructor to prevent external instantiation
    private Logger()
    {
    }

    // Public method to get the single instance of Logger
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    // Public method to log a message
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Access the Logger instance using the GetInstance method
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        // Both logger1 and logger2 refer to the same instance
        Console.WriteLine(logger1 == logger2); // Output: True

        logger1.Log("This is a log message.");
        logger2.Log("Another log message.");
    }
}
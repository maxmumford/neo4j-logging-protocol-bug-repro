using Neo4j.Driver;

namespace neo4j_logging_test;

public class Neo4jGraphDriverLogger : ILogger
{
    public void Error(Exception ex, string message, params object[] args)
    {
        Console.WriteLine(ex.ToString(), message, args);
    }

    public void Warn(Exception cause, string message, params object[] args)
    {
        Console.WriteLine(message, args);
    }

    public void Info(string message, params object[] args)
    {
        Console.WriteLine(message, args);
    }

    public void Debug(string message, params object[] args)
    {
        Console.WriteLine(message, args);
    }

    public void Trace(string message, params object[] args)
    {
        Console.WriteLine(message, args);
    }

    public bool IsTraceEnabled()
    {
        return false;
    }

    public bool IsDebugEnabled()
    {
        return false;
    }
}
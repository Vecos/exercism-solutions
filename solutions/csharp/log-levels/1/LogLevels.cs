static class LogLine
{
public static string Message(string logLine)
{
    string message = "";
    bool pom = false;

    for (int i = 0; i < logLine.Length; i++)
    {
        if (pom)
        {
            message += logLine[i];
        }

        if (logLine[i] == ':')
        {
            pom = true;
        }
    }

    return message.Trim();
}

    

public static string LogLevel(string logLine)
{
    string log = "";
    bool pom = false;
    for(int i = 0; i < logLine.Length; i++)
    {
        if(pom)
        {
            if(logLine[i] == ']')
            {break;}
            log += logLine[i];
        }
            
        if (logLine[i] == '[')
        {
        pom = true;
        }
     
    }
    return log.ToLower();
}


    public static string Reformat(string logLine)
    {
    return Message(logLine) + " (" + LogLevel(logLine) +")";
    }
}

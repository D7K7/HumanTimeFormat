using System.Collections.Generic;
using System.Text;

public class HumanTimeFormat
{
    public static string CreateMessage(int _years, int _days, int _hours, int _minutes, int _seconds)
    {
        Dictionary<string, int> timeUnits = new Dictionary<string, int>
        {
            { "year", _years },
            { "day", _days },
            { "hour", _hours },
            { "minute", _minutes },
            { "second", _seconds }
        };
    
        List<string> parts = new List<string>();
        foreach (var kvp in timeUnits)
        {
            if (kvp.Value > 0)
            {
                parts.Add(kvp.Value + " " + kvp.Key + (kvp.Value > 1 ? "s" : ""));
            }
        }
    
        StringBuilder formattedMessage = new StringBuilder();
        for (int i = 0; i < parts.Count; i++)
        {
            if (i > 0)
            {
                if (i == parts.Count - 1)
                {
                    formattedMessage.Append(" and ");
                }
                else
                {
                    formattedMessage.Append(", ");
                }
            }
            formattedMessage.Append(parts[i]);
        }
    
        return formattedMessage.ToString();
    }

    public static string formatDuration(int seconds)
    {
        if (seconds.Equals(0)) return "now";

        int years = 0, days = 0, hours = 0, minutes = 0;

        // Years
        years = seconds / 31536000;
        seconds -= years * 31536000;

        // Days
        days = seconds / 86400;
        seconds -= days * 86400;

        // Hours
        hours = seconds / 3600;
        seconds -= hours * 3600;

        // Minutes
        minutes = seconds / 60;
        seconds -= minutes * 60;
    
      
        return CreateMessage(years, days, hours, minutes, seconds);
    }
}

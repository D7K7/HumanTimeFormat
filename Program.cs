using System.Text;

public class HumanTimeFormat{
  public static string CreateMessage(int _years, int _days, int _hours, int _minutes, int _seconds)
  {
      StringBuilder message = new StringBuilder();
      string commaSeparator = ", ";
  
      //Years
      if (!_years.Equals(0)) message.Append(_years + (_years == 1 ? " year" : " years"));
      //Joining String
      if (!_years.Equals(0) && !_days.Equals(0)) message.Append(commaSeparator);
      //Days
      if (!_days.Equals(0)) message.Append(_days + (_days == 1 ? " day" : " days"));
      //Joining String
      if (!_days.Equals(0) && !_hours.Equals(0)) message.Append(commaSeparator);
      //Hours
      if (!_hours.Equals(0)) message.Append(_hours + (_hours == 1 ? " hour" : " hours"));
      //Joining String
      if (!_hours.Equals(0) && !_minutes.Equals(0)) message.Append(commaSeparator);
      //Minutes
      if (!_minutes.Equals(0)) message.Append(_minutes + (_minutes == 1 ? " minute" : " minutes"));
      //Joining String
      if (!_minutes.Equals(0) && !_seconds.Equals(0)) message.Append(" and ");
      //Seconds
      if (!_seconds.Equals(0)) message.Append(_seconds + (_seconds == 1 ? " second" : " seconds"));
  
      return message.ToString();
  }

  public static string formatDuration(int seconds)
  {
      if (seconds.Equals(0)) return "now";
  
      int years = 0, days = 0, hours = 0, minutes = 0;
  
      //Years
  
          years = seconds / 31536000;
          seconds -= years * 31536000;
  
      //Days
  
          days = seconds / 86400;
          seconds -= days * 86400;
  
      //Hours
  
          hours = seconds / 3600;
          seconds -= hours * 3600;
  
      //Minutes
  
          minutes = seconds / 60;
          seconds -= minutes * 60;
  
      return CreateMessage(years,days,hours, minutes, seconds);
  }
}

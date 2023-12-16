using System.Text;

public class HumanTimeFormat{
  public static string formatDuration(int seconds){
    if (seconds.Equals(0)) return "now";
    
    StringBuilder readableFormat = new StringBuilder();

    int years = 0, days = 0, hours = 0, minutes = 0;

    //Years
    if (seconds % 31536000 != 0)
    {
        years = seconds / 31536000;
        seconds = seconds - (years * 31536000);

        if (!years.Equals(0)) readableFormat.Append(years + (years == 1 ? " year" : " years"));
    }

    //Days
    if (seconds % 86400 != 0)
    {
        if (!years.Equals(0))
        {
            readableFormat.Append(", ");
        }

        days = seconds / 86400;
        seconds = seconds - (days * 86400);
        if (!days.Equals(0)) readableFormat.Append(days + (days == 1 ? " day" : " days"));
    }

    //Hours
    if (seconds % 3600 != 0)
    {
        if (!days.Equals(0))
        {
            readableFormat.Append(", ");
        }
        hours = seconds / 3600;
        seconds = seconds - (hours * 3600);
        if (!days.Equals(0)) readableFormat.Append(hours + (hours == 1 ? " hour" : " hours"));
    }

    //Minutes
    if (seconds % 60 != 0)
    {
        if (!days.Equals(0))
        {
            readableFormat.Append(", ");
        }
        minutes = seconds / 60;
        seconds = seconds - (minutes * 60);
        if (!minutes.Equals(0)) readableFormat.Append(minutes + (minutes == 1 ? " minute" : " minutes"));
    }

    if (!minutes.Equals(0)) readableFormat.Append(" and " + seconds + (seconds == 1 ? " second" : " seconds"));

    return readableFormat.ToString();
  }
}

using System;

class GuessTheDate
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        string strMonth = "";
        if (day == 1)
        {

        }
        switch (month)
        {
            case 1:
                strMonth += "Jan";
                break;
            case 2:
                strMonth += "Feb";
                break;
            case 3:
                strMonth += "Mar";
                break;
            case 4:
                strMonth += "Apr";
                break;
            case 5:
                strMonth += "May";
                break;
            case 6:
                strMonth += "Jun";
                break;
            case 7:
                strMonth += "Jul";
                break;
            case 8:
                strMonth += "Aug";
                break;
            case 9:
                strMonth += "Sep";
                break;
            case 10:
                strMonth += "Oct";
                break;
            case 11:
                strMonth += "Nov";
                break;
            case 12:
                strMonth += "Dec";
                break;
            default:
                break;
        }
        Console.WriteLine(day - 1 + "-" + strMonth + "-" + year);
    }
    }


namespace TimeFields;

internal class Time
{
    private int hours;
    private int minutes;
    private int seconds;

    public int Hours 
    {
        get{return hours;}
        set{ if(hours >=0 && hours <= 24) hours = value;}
    }

    public int Minutes
    {
        get{return minutes;}
        set{ if(minutes >= 0 && minutes <= 60) minutes = value;}
    }

    public int Seconds
    {
        get{return seconds;}
        set{ if(seconds >= 0 && seconds <= 60) seconds = value;}
    }

    public Time(){
        hours = 0;
        minutes = 0;
        seconds = 0;
    }

    public Time(int hrs, int mins, int secs){
        Hours = hrs;
        Minutes = mins;
        Seconds = secs;
    }

    public override string ToString() 
    {
        return $"The time is {hours:f2}:{minutes:f2}:{seconds:f2}";
    }
}

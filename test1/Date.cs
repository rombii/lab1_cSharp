namespace test1;

public class Date
{
    private int days;
    private int months;
    private int year;


    public Date(int days, int months, int year)
    {
        this.days = days;
        this.months = months;
        this.year = year;
    }
    
    public string readDate()
    {
        return days + "/" + months + "/" + year;
    }

    public void addWeek()
    {
        this.days += 7;
        if (this.months < 8 && this.months % 2 == 1)
        {
            if (this.days > 31)
            {
                this.months++;
                this.days -= 31;
            }
        } else if (this.months >= 8 && this.months % 2 == 0)
        {
            if (this.days > 31)
            {
                this.months++;
                this.days -= 31;
                if (this.months > 12)
                {
                    this.year++;
                    this.months -= 12;
                }
            }
        }
        else
        {
            if (this.months == 2)
            {
                if (this.days > 28)
                {
                    this.months++;
                    this.days -= 28;
                }
            }
            else
            {
                if (this.days > 30)
                {
                    this.months++;
                    this.days -= 30;
                }
            }
            
        }
    }
    
    public void removeWeek()
    {
        this.days -= 7;
        if (this.months < 8 && this.months % 2 == 1)
        {
            if (this.days < 1)
            {
                if (this.months == 3)
                {
                    if (this.days < 1)
                    {
                        this.months--;
                        this.days = 28 + this.days;
                    }
                }
                else
                {
                    this.months--;
                    this.days = 30 + this.days;
                    if (this.months < 1)
                    {
                        this.year--;
                        this.months = 12 - this.months;
                        this.days++;
                    }
                }
                
            }
        } else if (this.months >= 8 && this.months % 2 == 0)
        {
            if (this.days < 1)
            {
                this.months--;
                this.days = 30 + this.days;
            }
        }
        else
        {
            if (this.days < 1)
                {
                    this.months--;
                    this.days = 31 + this.months;
                }

        }
    }
}
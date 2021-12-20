namespace test1;

public class Sumator
{
    private int[] Liczby = new [] {1,5,2,6,9,67};

    public Sumator() {}

    public Sumator(int[] Array)
    {
        Liczby = Array;
    }
    
    public int Sum()
    {
        int sum = 0;
        foreach (int number in Liczby)
        {
            sum += number;
        }

        return sum;
    }
    
    public int SumPodziel2()
    {
        int sum = 0;
        foreach (int number in Liczby)
        {
            if(number % 2 == 0)
                sum += number;
        }

        return sum;
    }

    public int countNumber()
    {
        return Liczby.Length;
    }

    public override string ToString()
    {
        string allNumbers = "";
        foreach (int number in Liczby)
        {
            allNumbers += number + " ";
        }
        return allNumbers;
    }

    public string NumbersFromRange(int lowIndex, int highIndex)
    {
        string numbersRange = "";
        if(lowIndex>=0 && highIndex<Liczby.Length && lowIndex<highIndex)
            for (int i = lowIndex; i <= highIndex; i++)
            {
                numbersRange += Liczby[i] + " ";
            }

        return numbersRange;
    }
    
}
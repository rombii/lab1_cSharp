namespace test1;

public class Liczba
{
    private int length;
    private int[] numberDigits;
    public Liczba(string number)
    {
        this.length = number.Length;
        this.numberDigits = new int[this.length];
        for (int i = 0; i < number.Length; i++)
        {
            numberDigits[i] = number[i]-48;
        }
    }

    public int showNumber()
    {
        int number = 0;
        for (int i = 0; i < numberDigits.Length; i++)
        {
            number += numberDigits[i] * (int)Math.Pow(10, numberDigits.Length - (i+1));
        }

        return number;
    }

    public int multiplyNumber(int multiply)
    {
        int number = 0;
        for (int i = 0; i < numberDigits.Length; i++)
        {
            number += numberDigits[i] * (int)Math.Pow(10, numberDigits.Length - (i+1));
        }

        return number * multiply;
    }

    public static int factorialNumber(int number)
    {
        int sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum *= i;
        }
        return sum;
    }
}
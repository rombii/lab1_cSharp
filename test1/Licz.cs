namespace test1;

public class Licz
{
    public float numberValue;

    public float Add(float a)
    {
        return numberValue += a;
    }

    public float Substract(float a)
    {
        return numberValue -= a;
    }

    public void ShowNumber()
    {
        Console.WriteLine(numberValue);
    }
}
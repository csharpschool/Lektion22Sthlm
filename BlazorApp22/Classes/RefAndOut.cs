namespace BlazorApp22.Classes;

public class RefAndOut
{
    public int Calculate(ref int x, int y, out int z)
    {
        var result = x + y;

        x = result * 2;
        y = x * 10;
        z = y * 100;
        return result;
    }
}

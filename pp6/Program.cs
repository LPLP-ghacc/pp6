public class Program
{
    public static void Main()
    {
        Trassa doroga = new Trassa();

        Car[] cars = doroga.Traffic();
        Car m1 = cars[0];

        for(int i = 0; i < 10; i++)
        {
            m1.Gas();

            Console.WriteLine($"position X: {m1.position.X}");
        }

        m1.Tormoz();

        Console.WriteLine($"position X: {m1.position.X}");
    }
}
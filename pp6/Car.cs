class Car
{
    public string color = "";
    public string kolesa = "";
    public string marka = "";
    public Position position = new Position();

    public void Gas()
    {
        position.X = position.X + 1;

        Console.WriteLine("we're gassing up!");
    }

    public void Tormoz()
    {
        position.X = 0;
        position.Y = 0;

        Console.WriteLine("we're slowing down!");
    }

    public void Povorot(string direction)
    {
        if(direction == "left")
        {
            Console.WriteLine("We turned left!");
        }

        if(direction == "right")
        {
            Console.WriteLine("We turned right!");
        }
    }
}


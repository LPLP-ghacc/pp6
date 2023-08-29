class Trassa
{
    public Car[] Traffic()
    {
        Car mazda = new Car();

        mazda.marka = "Mazda";
        mazda.kolesa = "крутые колеса";
        mazda.color = "Red";

        Car nissan = new Car();

        nissan.marka = "Nissan";
        nissan.kolesa = "средние колеса";
        nissan.color = "Yellow";


        Car[] cars = new Car[2];

        cars[0] = mazda;
        cars[1] = nissan;

        return cars;
    }
}


internal class WildAnimalFactory : IAnimalFactory
{
    public IDog CreateDog()
    {
        return new WildDog();
    }

    public ICat CreateCat()
    {
        return new WildCat();
    }
}
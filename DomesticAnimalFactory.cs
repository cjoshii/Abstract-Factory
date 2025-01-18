internal class DomesticAnimalFactory : IAnimalFactory
{
    public IDog CreateDog()
    {
        return new DomesticDog();
    }

    public ICat CreateCat()
    {
        return new DomesticCat();
    }
}
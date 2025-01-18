internal class DomesticAnimalFactory : IAnimalFactory
{
    private DomesticAnimalFactory()
    {

    }

    private static DomesticAnimalFactory? _instance;

    internal static DomesticAnimalFactory Instance
    {
       get{
            _instance ??= new DomesticAnimalFactory();
            return _instance;
       }
    }

    public IDog CreateDog()
    {
        return new DomesticDog();
    }

    public ICat CreateCat()
    {
        return new DomesticCat();
    }
}
internal class WildAnimalFactory : IAnimalFactory
{
    private static WildAnimalFactory? _instance;    

    private WildAnimalFactory()
    {

    }

    public static WildAnimalFactory Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new WildAnimalFactory();
            }
            return _instance;
        }
    }

    public IDog CreateDog()
    {
        return new WildDog();
    }

    public ICat CreateCat()
    {
        return new WildCat();
    }
}
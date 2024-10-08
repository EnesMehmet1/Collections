using GenericCollections.CollectionClasses;
using GenericCollections.CollectionInterfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //GetGenericCollection(new MyList());
        GetGenericCollection(new MyStack());
    }

    private static void GetGenericCollection(IGenericCollections collectionObject)
    {
        collectionObject.GetCollection();
    }

}
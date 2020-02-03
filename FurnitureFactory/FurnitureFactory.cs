using System;

public abstract class FurnitureFactory
{
    public abstract FurnitureSet viewFurniture();
    public abstract void buildFurniture();

    public static FurnitureFactory createFurnitureFactory(string type)
    {
        switch(type.ToUpper())
        {
            case "FRENCH":
                return new FrenchFurnitureFactory();
            case "ITALIAN":
                return new ItalianFurnitureFactory();
            case "JAPANESE":
                return new JapaneseFurnitureFactory();
            default:
                return null;
        }
    }
}

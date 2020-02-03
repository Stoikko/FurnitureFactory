using System;

public class FrenchFurnitureFactory : FurnitureFactory
{
    private FurnitureSet furnitureSet;

    public override FurnitureSet viewFurniture()
    {
        return this.furnitureSet;
    }

    public override void buildFurniture()
    {
        Console.WriteLine("French Factory has recieved the order; processing...");

        FurnitureSet furnitureSet = new FurnitureSet();
        furnitureSet.setChair(new FrenchChair());
        Console.WriteLine(furnitureSet.getChair().getStyle() + " chair crafted.");

        furnitureSet.setTable(new FrenchTable());
        Console.WriteLine(furnitureSet.getTable().getStyle() + " table crafted.");

        furnitureSet.setSofa(new FrenchSofa());
        Console.WriteLine(furnitureSet.getSofa().getStyle() + " sofa crafted.");

        furnitureSet.setType("French");

        Console.WriteLine("French Factory packaged a the furniture set.");

        this.furnitureSet = furnitureSet;
    }
}

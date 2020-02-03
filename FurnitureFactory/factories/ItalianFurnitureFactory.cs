using System;

public class ItalianFurnitureFactory : FurnitureFactory
{
    private FurnitureSet furnitureSet;

    public override FurnitureSet viewFurniture()
    {
        return this.furnitureSet;
    }

    public override void buildFurniture()
    {
        Console.WriteLine("Italian Factory has recieved the order; processing...");

        FurnitureSet furnitureSet = new FurnitureSet();
        furnitureSet.setChair(new ItalianChair());
        Console.WriteLine(furnitureSet.getChair().getStyle() + " chair crafted.");

        furnitureSet.setTable(new ItalianTable());
        Console.WriteLine(furnitureSet.getTable().getStyle() + " table crafted.");

        furnitureSet.setSofa(new ItalianSofa());
        Console.WriteLine(furnitureSet.getSofa().getStyle() + " sofa crafted.");

        furnitureSet.setType("Italian");

        Console.WriteLine("Italian Factory packaged a the furniture set.");

        this.furnitureSet = furnitureSet;
    }
}

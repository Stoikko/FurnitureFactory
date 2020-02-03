using System;

public class JapaneseFurnitureFactory : FurnitureFactory
{
    private FurnitureSet furnitureSet;

    public override FurnitureSet viewFurniture()
    {
        return this.furnitureSet;
    }

    public override void buildFurniture()
    {
        Console.WriteLine("Japanese Factory has recieved the order; processing...");

        FurnitureSet furnitureSet = new FurnitureSet();
        furnitureSet.setChair(new JapaneseChair());
        Console.WriteLine(furnitureSet.getChair().getStyle() + " chair crafted.");

        furnitureSet.setTable(new JapaneseTable());
        Console.WriteLine(furnitureSet.getTable().getStyle() + " table crafted.");

        furnitureSet.setSofa(new JapaneseSofa());
        Console.WriteLine(furnitureSet.getSofa().getStyle() + " sofa crafted.");

        furnitureSet.setType("Japanese");

        Console.WriteLine("Japanese Factory packaged a the furniture set.");
        
        this.furnitureSet = furnitureSet;
    }
}

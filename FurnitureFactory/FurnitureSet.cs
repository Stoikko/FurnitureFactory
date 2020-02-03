using System;

public class FurnitureSet
{
    private string type;
    private Chair chair;
    private Table table;
    private Sofa sofa;

    public string getType()
    {
        return this.type;
    }

    public void setType(string type)
    {
        this.type = type;
    }

    public Chair getChair()
    {
        return this.chair;
    }

    public void setChair(Chair chair)
    {
        this.chair = chair;
    }

    public Table getTable()
    {
        return this.table;
    }

    public void setTable(Table table)
    {
        this.table = table;
    }

    public Sofa getSofa()
    {
        return this.sofa;
    }

    public void setSofa(Sofa sofa)
    {
        this.sofa = sofa;
    }
}

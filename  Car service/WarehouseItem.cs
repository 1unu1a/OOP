namespace Car.Service;

public class WarehouseItem
{
    public Part Part { get; }
    public int Count { get; private set; }

    public WarehouseItem(Part part, int quantity)
    {
        Part = part;
        Count = quantity;
    }

    public bool Take()
    {
        if (Count <= 0)
        {
            return false;
        }
        
        Count--;
        return true;
    }

    public void Add(int count) => Count += count;
}
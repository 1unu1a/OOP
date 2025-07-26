namespace Car.Service;

public class PartStockItem
{
    public Part Part { get; }
    public int Quantity { get; private set; }

    public PartStockItem(Part part, int quantity)
    {
        Part = part;
        Quantity = quantity;
    }

    public bool Take()
    {
        if (Quantity <= 0)
        {
            return false;
        }
        
        Quantity--;
        return true;
    }

    public void Add(int count) => Quantity += count;
}
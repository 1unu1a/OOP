namespace My.Home.Work.Oop;

public class TicketService
{
    private Random random = new Random();

    public int GeneratePassengers()
    {
        return random.Next(10, 111);
    }
}
namespace My.Home.Work.Oop;

public class MockTicketService : ITicketService
{
    private Random random = new Random();

    public int GetPassengerCount() => random.Next(10, 111);
}
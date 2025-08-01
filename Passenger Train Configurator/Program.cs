namespace My.Home.Work.Oop;

internal class Program
{
    static void Main(string[] args)
    {
        RouteService routeService = new RouteService();
        MockTicketService ticketService = new MockTicketService();
        WagonFactory wagonFactory = new WagonFactory();
        TrainFactory trainFactory = new TrainFactory(wagonFactory);
        TrainPlanner planner = new TrainPlanner(routeService, ticketService, trainFactory);

        while (true)
        {
            if (routeService.HasActiveRoute())
            {
                var route = routeService.CurrentRoute!;
                Console.WriteLine("Состояние рейса:");
                Console.WriteLine($"Маршрут: {route}");
                Console.WriteLine($"Пассажиров: {route.Passengers}");
                route.Train?.ShowTrain();
            }
            else
            {
                Console.WriteLine("Рейс не задан.");
            }

            planner.PrintMenu();

            string input = Console.ReadLine();
            if (input == "0")
            {
                break;
            }

            planner.HandleInput(input); 
        }
    }
}
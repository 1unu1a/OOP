namespace My.Home.Work.Oop;

public class TrainPlanner
{
    private readonly RouteService routeService;
    private readonly ITicketService ticketService;
    private readonly TrainFactory trainFactory;

    public TrainPlanner(RouteService routeService, ITicketService ticketService, TrainFactory trainFactory)
    {
        this.routeService = routeService;
        this.ticketService = ticketService;
        this.trainFactory = trainFactory;
    }

    public void PrintMenu()
    {
        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Создать направление");
        Console.WriteLine("2. Продать билеты");
        Console.WriteLine("3. Сформировать поезд");
        Console.WriteLine("4. Отправить поезд");
        Console.WriteLine("0. Выход");
    }

    public void HandleInput(string input)
    {
        switch (input)
        {
            case "1": 
                CreateRoute();
                break;
            
            case "2": 
                SellTickets(); 
                break;
            
            case "3": 
                FormTrain(); 
                break;
            
            case "4": 
                SendTrain(); 
                break;
            
            default: 
                Console.WriteLine("Неизвестная команда."); 
                break;
        }
    }

    private void CreateRoute()
    {
        Console.Write("Откуда: ");
        string from = Console.ReadLine();
        Console.Write("Куда: ");
        string to = Console.ReadLine();

        routeService.CreateRoute(from, to);
        Console.WriteLine("Маршрут создан.");
    }

    private void SellTickets()
    {
        if (!routeService.HasActiveRoute())
        {
            Console.WriteLine("Сначала создайте направление.");
            return;
        }

        int passengers = ticketService.GetPassengerCount();
        routeService.CurrentRoute!.Passengers = passengers;
        Console.WriteLine($"Продано билетов: {passengers}");
    }

    private void FormTrain()
    {
        if (!routeService.HasActiveRoute())
        {
            Console.WriteLine("Сначала создайте направление.");
            return;
        }

        var route = routeService.CurrentRoute!;
        if (route.Passengers == 0)
        {
            Console.WriteLine("Нет пассажиров. Сначала продайте билеты.");
            return;
        }

        var train = trainFactory.CreateTrain(route.Passengers);
        route.AssignTrain(train);
        Console.WriteLine("Поезд сформирован.");
    }

    private void SendTrain()
    {
        if (!routeService.HasActiveRoute() || routeService.CurrentRoute!.Train == null)
        {
            Console.WriteLine("Поезд не сформирован или маршрут не задан.");
            return;
        }

        try
        {
            routeService.SendCurrentRoute();
            Console.WriteLine($"Поезд по маршруту {routeService.CurrentRoute} отправлен!");
            routeService.ClearRoute();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при отправке: {ex.Message}");
        }
    }
}
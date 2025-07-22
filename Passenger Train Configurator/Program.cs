namespace My.Home.Work.Oop;

internal class Program
{
    static void Main(string[] args)
    {
        RouteService routeService = new RouteService();
        TicketService ticketService = new TicketService();
        TrainService trainService = new TrainService();

        Route? currentRoute = null;
        Train? currentTrain = null;
        int passengers = 0;

        while (true)
        {
            Console.WriteLine("Состояние рейса:");
            if (routeService.HasActiveRoute())
            {
                Console.WriteLine($"Маршрут: {routeService.CurrentRoute}");
                Console.WriteLine($"Пассажиров: {passengers}");
                currentTrain?.ShowTrain();
            }
            else
            {
                Console.WriteLine("Рейс не задан.");
            }

            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Создать направление");
            Console.WriteLine("2. Продать билеты");
            Console.WriteLine("3. Сформировать поезд");
            Console.WriteLine("4. Отправить поезд");
            Console.WriteLine("0. Выход");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Откуда: ");
                    string from = Console.ReadLine();
                    Console.Write("Куда: ");
                    string to = Console.ReadLine();
                    routeService.CreateRoute(from, to);
                    passengers = 0;
                    currentTrain = null;
                    break;

                case "2":
                    if (!routeService.HasActiveRoute())
                    {
                        Console.WriteLine("Сначала создайте направление.");
                        break;
                    }

                    passengers = ticketService.GeneratePassengers();
                    Console.WriteLine($"Продано билетов: {passengers}");
                    break;

                case "3":
                    if (passengers == 0)
                    {
                        Console.WriteLine("Нет пассажиров. Сначала продайте билеты.");
                        break;
                    }

                    currentTrain = trainService.FormTrain(passengers);
                    Console.WriteLine("Поезд сформирован.");
                    break;

                case "4":
                    if (currentTrain == null)
                    {
                        Console.WriteLine("Поезд не сформирован.");
                        break;
                    }

                    Console.WriteLine($"Поезд по маршруту {routeService.CurrentRoute} отправлен!");
                    routeService.ClearRoute();
                    passengers = 0;
                    currentTrain = null;
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Неизвестная команда.");
                    break;
            }
        }
    }
}
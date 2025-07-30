namespace My.Home.Work.Oop;

public class RouteService
{
    public Route? CurrentRoute { get; private set; }

    public void CreateRoute(string from, string to)
    {
        CurrentRoute = new Route(from, to);
    }

    public bool HasActiveRoute() => CurrentRoute != null;

    public void ClearRoute() => CurrentRoute = null;
    
    public void SendCurrentRoute()
    {
        if (CurrentRoute == null)
        {
            throw new InvalidOperationException("Нет маршрута для отправки.");
        }
    }
}
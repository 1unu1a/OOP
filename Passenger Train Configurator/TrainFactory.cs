namespace My.Home.Work.Oop;

public class TrainFactory
{
    private readonly WagonFactory wagonFactory;

    public TrainFactory(WagonFactory wagonFactory)
    {
        this.wagonFactory = wagonFactory;
    }

    public Train CreateTrain(int passengers)
    {
        Train train = new Train();
        int remaining = passengers;

        while (remaining > 0)
        {
            var wagon = wagonFactory.CreateWagon(remaining);
            train.AddWagon(wagon);
            remaining -= wagon.Capacity;
        }

        return train;
    }
}
namespace My.Home.Work.Oop;

public class TrainService
{
    public Train FormTrain(int passengerCount)
    {
        Train train = new Train();
        int remaining = passengerCount;

        while (remaining > 0)
        {
            Wagon wagon;

            if (remaining >= 54)
            {
                wagon = new PlatzkartWagon();
            }
            else if (remaining >= 36)
            {
                wagon = new CoupeWagon();
            }
            else
            {
                wagon = new CoupeWagon();
            }

            train.AddWagon(wagon);
            remaining -= wagon.Capacity;
        }

        return train;
    }
}
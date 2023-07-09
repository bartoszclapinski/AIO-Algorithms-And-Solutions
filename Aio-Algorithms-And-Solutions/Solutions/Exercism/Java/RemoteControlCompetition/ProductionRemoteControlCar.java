package exercism;

public class ProductionRemoteControlCar implements RemoteControlCar, Comparable<ProductionRemoteControlCar> {
    private int distanceTravelled = 0;
    private int victories = 0;

    @Override
    public void drive() {
        distanceTravelled += 10;
    }

    @Override
    public int getDistanceTravelled() {
        return distanceTravelled;
    }

    public void setNumberOfVictories(int victories) {
        this.victories = victories;
    }

    public int getNumberOfVictories() {
        return victories;
    }

    @Override
    public int compareTo(ProductionRemoteControlCar car) {
        return car.victories - this.victories;
    }
}

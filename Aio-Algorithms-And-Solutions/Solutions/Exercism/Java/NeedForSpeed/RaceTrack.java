package exercism;

class RaceTrack {
    private final int distance;

    public RaceTrack(int distance) {
        this.distance = distance;
    }

    public boolean tryFinishTrack(NeedForSpeed car) {
        while (car.distanceDriven() < distance) {
            if (car.batteryDrained()) return false;
            car.drive();
        }
        return true;
    }
}

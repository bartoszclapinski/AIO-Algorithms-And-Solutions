package exercism;

public class ElonsToyCar {
    private int distanceDriven;
    private int batteryPercentage;

    ElonsToyCar() {
        this.distanceDriven = 0;
        this.batteryPercentage = 100;
    }

    public static ElonsToyCar buy() {
        return new ElonsToyCar();
    }

    public String distanceDisplay() {
        return "Driven " + this.distanceDriven + " meters";
    }

    public String batteryDisplay() {
        return this.batteryPercentage == 0 ? "Battery empty" : "Battery at " + this.batteryPercentage + "%";
    }

    public void drive() {
        if (this.batteryPercentage == 0) return;

        this.distanceDriven += 20;
        this.batteryPercentage -= 1;
    }
}










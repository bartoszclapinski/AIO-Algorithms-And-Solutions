package exercism;

public class BirdWatcher {
    private final int[] _birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) {
        _birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
        return _birdsPerDay.clone();
    }

    public int getToday() {
        return _birdsPerDay[_birdsPerDay.length - 1];
    }

    public void incrementTodaysCount() {
        _birdsPerDay[_birdsPerDay.length - 1]++;
    }

    public boolean hasDayWithoutBirds() {
        for (int birds : _birdsPerDay) {
            if (birds == 0) {
                return true;
            }
        }
        return false;
    }

    public int getCountForFirstDays(int numberOfDays) {
        if (numberOfDays > _birdsPerDay.length) {
            numberOfDays = _birdsPerDay.length;
        }
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++) {
            sum += _birdsPerDay[i];
        }
        return sum;
    }

    public int getBusyDays() {
        int busyDays = 0;
        for (int birds : _birdsPerDay) {
            if (birds >= 5) {
                busyDays++;
            }
        }
        return busyDays;
    }

}

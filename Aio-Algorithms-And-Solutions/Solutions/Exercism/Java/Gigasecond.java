import java.time.LocalDate;
import java.time.LocalDateTime;

public class Gigasecond {

    private static final long GIGASECOND = 1_000_000_000L;
    private final LocalDateTime _moment;

    public Gigasecond(LocalDate moment) {
        _moment = moment.atStartOfDay();
    }

    public Gigasecond(LocalDateTime moment) {
        _moment = moment;
    }

    public LocalDateTime getDateTime() {
        return _moment.plusSeconds(GIGASECOND);
    }
}
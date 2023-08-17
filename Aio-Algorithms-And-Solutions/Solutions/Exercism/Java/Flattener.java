package exercism;
import java.util.*;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;
public class Flattener {
    public static List<Object> flatten(List<Object> input) {
        return input
                .stream()
                .flatMap(e -> (!(e instanceof List)) ? Stream.of(e) : Flattener.flatten((List<Object>) e).stream())
                .filter(Objects::nonNull)
                .collect(Collectors.toList());
    }
}
package exercism;
import java.util.Arrays;
import java.util.Map;
import java.util.function.Function;
import java.util.stream.Collectors;
public class WordCount {
    public Map<String,Integer> phrase(String word) {
        return Arrays.stream(word
                        .toLowerCase()
                        .replaceAll("[^a-z0-9' ]", " ")
                        .trim()
                        .split("\\s+"))
                .map(it -> it.replaceAll("^'|'$", ""))
                .collect(Collectors.groupingBy(Function.identity(), Collectors.counting()))
                .entrySet().stream()
                .collect(Collectors.toMap(Map.Entry::getKey, it -> it.getValue().intValue()));
    }
}
package exercism;

import java.util.stream.Collectors;
import java.util.*;

public class Robot {
    private static final Set<String> registeredNames = new HashSet<String>();
    private static final Random random = new Random();
    private String name;
    public Robot() {
        reset();
    }
    public String getName() {
        return name;
    }
    public void reset() {
        registeredNames.remove(this.name);
        String name;
        while (true) {
            if (!registeredNames.contains(name = generateName())) break;
        }
        registeredNames.add(name);
        this.name = name;
    }
    private static String randomString(char fromChar, char toChar, int len) {
        return random.ints(fromChar, toChar + 1).limit(len)
                .mapToObj(ch -> Character.toString((char)ch))
                .collect(Collectors.joining());
    }
    private static String generateName() {
        return randomString('A', 'Z', 2) + randomString('0', '9', 3);
    }
}
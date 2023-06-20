import java.util.Map;
import java.util.HashMap;

class Scrabble {
    private int score;

    private static final Map<Character, Integer> letterValues;

    static {
        letterValues = new HashMap<>();
        letterValues.put('A', 1); letterValues.put('E', 1);
        letterValues.put('I', 1); letterValues.put('O', 1);
        letterValues.put('U', 1); letterValues.put('L', 1);
        letterValues.put('N', 1); letterValues.put('R', 1);
        letterValues.put('S', 1); letterValues.put('T', 1);
        letterValues.put('D', 2); letterValues.put('G', 2);
        letterValues.put('B', 3); letterValues.put('C', 3);
        letterValues.put('M', 3); letterValues.put('P', 3);
        letterValues.put('F', 4); letterValues.put('H', 4);
        letterValues.put('V', 4); letterValues.put('W', 4);
        letterValues.put('Y', 4); letterValues.put('K', 5);
        letterValues.put('J', 8); letterValues.put('X', 8);
        letterValues.put('Q', 10); letterValues.put('Z', 10);
    }

    Scrabble(String word) {
        if (word != null) {
            for (char c : word.toUpperCase().toCharArray()) {
                score += letterValues.getOrDefault(c, 0);
            }
        }
    }

    int getScore() {
        return score;
    }
}

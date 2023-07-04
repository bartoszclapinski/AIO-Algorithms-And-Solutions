package exercism;

import java.util.HashSet;

public class PangramChecker {

    private static final int TOTAL_LETTERS_IN_ALPHABET = 26;

    public boolean isPangram(String input) {
        var letters = new HashSet<Character>();
        for (char c : input.toLowerCase().toCharArray())
            if (Character.isLetter(c)) letters.add(c);
        return letters.size() == TOTAL_LETTERS_IN_ALPHABET;
    }
}







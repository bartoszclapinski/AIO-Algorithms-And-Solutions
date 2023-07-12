package exercism;

public class RotationalCipher {
    private final int shiftKey;

    RotationalCipher(int shiftKey) {
        this.shiftKey = shiftKey;
    }

    String rotate(String data) {
        var result = new StringBuilder();
        for (char character : data.toCharArray()) {
            if (Character.isAlphabetic(character)) {
                var base = Character.isLowerCase(character) ? 'a' : 'A';
                character = (char) ((character - base + shiftKey) % 26 + base);
            }
            result.append(character);
        }
        return result.toString();
    }
}



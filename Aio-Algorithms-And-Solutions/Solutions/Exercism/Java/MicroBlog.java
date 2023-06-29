package exercism;

public class MicroBlog {
    public String truncate(String input) {
        if (input == null) {
            return null;
        }
        int length = input.codePointCount(0, input.length());
        if (length <= 5) {
            return input;
        }
        int endIndex = input.offsetByCodePoints(0, 5);
        return input.substring(0, endIndex);
    }
}


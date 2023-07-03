package exercism;

public class Say {
    private static final String[] smallNumbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
    private static final String[] tensNumbers = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
    private static final String[] scaleNumbers = {"thousand", "million", "billion"};

    public String say(long number) {
        if (number < 0 || number > 999_999_999_999L) {
            throw new IllegalArgumentException("The number is out of range.");
        }
        if (number < 20) {
            return smallNumbers[(int) number];
        }
        if (number < 100) {
            return tensNumbers[(int) number / 10 - 2] + (number % 10 != 0 ? "-" + say(number % 10) : "");
        }
        if (number < 1_000) {
            return smallNumbers[(int) number / 100] + " hundred" + (number % 100 != 0 ? " " + say(number % 100) : "");
        }

        for (int i = 0; i < scaleNumbers.length; i++) {
            if (number < Math.pow(1_000, i + 2)) {
                return say(number / (long) Math.pow(1_000, i + 1)) + " " + scaleNumbers[i] + (number % Math.pow(1_000, i + 1) != 0 ? " " + say(number % (long) Math.pow(1_000, i + 1)) : "");
            }
        }
        return say(number / 1_000_000_000_000L) + " trillion" + (number % 1_000_000_000_000L != 0 ? " " + say(number % 1_000_000_000_000L) : "");
    }
}





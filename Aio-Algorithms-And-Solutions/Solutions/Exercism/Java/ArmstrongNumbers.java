package exercism;

 public class ArmstrongNumbers {

    boolean isArmstrongNumber(int numberToCheck) {
        var numberString = String.valueOf(numberToCheck);
        var length = numberString.length();

        var sum = 0;
        for (char c : numberString.toCharArray()) {
            int digit = Character.getNumericValue(c);
            sum += Math.pow(digit, length);
        }

        return sum == numberToCheck;
    }

}






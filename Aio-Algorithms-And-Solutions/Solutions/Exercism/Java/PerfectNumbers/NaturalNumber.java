package exercism;

public class NaturalNumber {

    private final int number;

    public NaturalNumber(int number) {
        if (number <= 0) {
            throw new IllegalArgumentException("You must supply a natural number (positive integer)");
        }
        this.number = number;
    }

    public Classification getClassification() {
        int sumOfFactors = 1;

        for (int i = 2; i <= Math.sqrt(number); i++) {
            if (number % i == 0) {
                if (i == number / i) {
                    sumOfFactors += i;
                } else {
                    sumOfFactors += i + number / i;
                }
            }
        }

        if (sumOfFactors == number && number != 1) {
            return Classification.PERFECT;
        } else if (sumOfFactors > number) {
            return Classification.ABUNDANT;
        } else {
            return Classification.DEFICIENT;
        }
    }
}




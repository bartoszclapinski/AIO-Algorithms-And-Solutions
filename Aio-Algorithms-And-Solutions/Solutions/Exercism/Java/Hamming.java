package exercism;

import java.util.stream.IntStream;

public class Hamming {
    private final int hammingDistance;

    public Hamming(String leftStrand, String rightStrand) {
        if (leftStrand.length() != rightStrand.length()) {
            if (leftStrand.isEmpty()) {
                throw new IllegalArgumentException("left strand must not be empty.");
            } else if (rightStrand.isEmpty()) {
                throw new IllegalArgumentException("right strand must not be empty.");
            } else {
                throw new IllegalArgumentException("leftStrand and rightStrand must be of equal length.");
            }
        }
        this.hammingDistance = calculateHammingDistance(leftStrand, rightStrand);
    }

    private int calculateHammingDistance(String leftStrand, String rightStrand) {
        return (int) IntStream.range(0, leftStrand.length())
                .filter(i -> leftStrand.charAt(i) != rightStrand.charAt(i))
                .count();
    }

    public int getHammingDistance() {
        return this.hammingDistance;
    }
}









package exercism;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Matrix {

    private int[][] matrix;

    Matrix(String matrixAsString) {
        var rows = matrixAsString.split("\n");
        matrix = Arrays.stream(rows)
                .map(row -> Arrays.stream(row.split(" "))
                        .mapToInt(Integer::parseInt)
                        .toArray())
                .toArray(int[][]::new);
    }

    int[] getRow(int rowNumber) {
        return matrix[rowNumber - 1];
    }

    int[] getColumn(int columnNumber) {
        return Arrays.stream(matrix)
                .mapToInt(row -> row[columnNumber - 1])
                .toArray();
    }
}


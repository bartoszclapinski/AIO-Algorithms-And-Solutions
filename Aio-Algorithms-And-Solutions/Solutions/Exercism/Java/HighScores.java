package exercism;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class HighScores {

    private final List<Integer> highScores;

    public HighScores(List<Integer> highScores) {
        this.highScores = highScores;
    }

    List<Integer> scores() {
        return highScores;
    }

    Integer latest() {
        return highScores.get(highScores.size() - 1);
    }

    Integer personalBest() {
        return Collections.max(highScores);
    }

    List<Integer> personalTopThree() {
        List<Integer> sortedScores = new ArrayList<>(highScores);
        sortedScores.sort(Collections.reverseOrder());
        return sortedScores.subList(0, Math.min(3, sortedScores.size()));
    }
}









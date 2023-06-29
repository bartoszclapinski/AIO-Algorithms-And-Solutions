package exercism;

class ResistorColorDuo {
    private static final String[] COLORS = {
            "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"
    };

    int value(String[] colors) {
        int value = 0;
        for (int i = 0; i < 2 && i < colors.length; i++) {
            for (int j = 0; j < COLORS.length; j++) {
                if (COLORS[j].equals(colors[i])) {
                    value = value * 10 + j;
                    break;
                }
            }
        }
        return value;
    }
}


package exercism;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class HandshakeCalculator {

    List<Signal> calculateHandshake(int number) {
        List<Signal> actions = new ArrayList<>();
        if ((number & 1) == 1) actions.add(Signal.WINK);
        if ((number & 2) == 2) actions.add(Signal.DOUBLE_BLINK);
        if ((number & 4) == 4) actions.add(Signal.CLOSE_YOUR_EYES);
        if ((number & 8) == 8) actions.add(Signal.JUMP);
        if ((number & 16) == 16) Collections.reverse(actions);
        return actions;
    }

}


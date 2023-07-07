package exercism;

public class SqueakyClean {
     static String clean(String identifier) {
        var sb = new StringBuilder();
         var nextIsUpper = false;

        for (char ch : identifier.toCharArray())
            if (ch == ' ') {
                sb.append('_');
            } else if (Character.isISOControl(ch)) {
                sb.append("CTRL");
            } else if (ch == '-') {
                nextIsUpper = true;
            } else if (!Character.isLetter(ch)) {
                // Skip non-letter characters
                continue;
            } else {
                // Convert kebab-case to camelCase and handle Greek lowercase letters
                if (nextIsUpper) {
                    sb.append(Character.toUpperCase(ch));
                    nextIsUpper = false;
                } else if (ch < 'α' || ch > 'ω') {
                    sb.append(ch);
                }
            }

        return sb.toString();
    }
}









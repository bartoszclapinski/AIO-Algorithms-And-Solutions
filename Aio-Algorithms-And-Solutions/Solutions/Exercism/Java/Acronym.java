package exercism;

 public class Acronym {

     private final String acronym;

     Acronym(String phrase) {
         var acronymBuilder = new StringBuilder();

         for (String word : phrase.split("[\\s_-]")) {
             if (!word.isEmpty()) {
                 acronymBuilder.append(word.charAt(0));
             }
         }

         acronym = acronymBuilder.toString().toUpperCase();
     }

     String get() {
         return acronym;
     }

 }







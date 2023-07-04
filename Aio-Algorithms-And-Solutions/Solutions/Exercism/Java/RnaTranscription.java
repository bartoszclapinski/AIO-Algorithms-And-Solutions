package exercism;

 public class RnaTranscription {

     String transcribe(String dnaStrand) {
         if (dnaStrand == null || dnaStrand.isEmpty()) return "";

         var rnaStrand = new StringBuilder();

         for (char dna : dnaStrand.toCharArray())
             switch (dna) {
                 case 'G' -> rnaStrand.append('C');
                 case 'C' -> rnaStrand.append('G');
                 case 'T' -> rnaStrand.append('A');
                 case 'A' -> rnaStrand.append('U');
                 default -> throw new IllegalArgumentException("Invalid input");
             }

         return rnaStrand.toString();
     }

 }






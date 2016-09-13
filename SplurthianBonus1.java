// Finds the, alphabetically, first valid Splurthian
// chemical symbol for a given element.

import java.util.*;

class SplurthianBonus1 {
    public static void main(String[] args) {
        System.out.println(findSymbol("Slimyrine"));
    }

    public static String findSymbol(String elem) {
        int first = findLetter(elem, 0, true);
        int second = findLetter(elem, first, false);
        String result = "";
        result = result.concat(Character.toString(elem.charAt(first)).toUpperCase());
        result = result.concat(Character.toString(elem.charAt(second)).toLowerCase());

        return result;
    } //close findSymbol

    public static int findLetter(String elem, int s, boolean firstLetter) {
        elem = elem.toLowerCase();
        int k;
        if (firstLetter == true) {
            k = 0;
        } else {
            k = 1;
        }
        char[] letters = new char[elem.length() - 1 - s];

        for (int i = s + k; i < elem.length() - 1 + k; i++) {
            letters[i - (s + k)] = elem.charAt(i);
        }

        Arrays.sort(letters);

        return elem.indexOf(letters[0]);
    } //close findLetter
} //close class

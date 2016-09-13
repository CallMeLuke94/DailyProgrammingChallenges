//Splurthian Chemical Symbol Verifier!

public class Splurth {
    public static void main(String[] args) {
        String element = "Venkmine";
        String symbol = "Kn";
        System.out.println(testSymbol(element, symbol));
    }

    public static boolean testSymbol(String elem, String symb) {
        elem = elem.toLowerCase();
        symb = symb.toLowerCase();
        int firstLetter = -1;
        int secondLetter = -1;

        for (int i = 0; i < elem.length() - 1; i++) {
            if (elem.charAt(i) == symb.charAt(0)) {
                firstLetter = i;
                break;
            }
        } //close for

        if (firstLetter == -1 || firstLetter == elem.length() - 1) {
            return false;
        }

        for (int j = firstLetter + 1; j < elem.length() - 1; j++) {
            if (elem.charAt(j) == symb.charAt(1)) {
                secondLetter = j;
                break;
            }
        } //close for

        if (secondLetter != -1) {
            return true;
        } else {
            return false;
        }

    } //close testSymbol
} //close class


// Example inputs:
// Spenglerium, Ee -> true
// Zeddemorium, Zr -> true
// Venkmine, Kn -> true
// Stantzon, Zt -> false
// Melintzum, Nn -> false
// Tullium, Ty -> false

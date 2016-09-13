//Test if two words are anagrams!

import java.util.*;

public class anagram {
    public static void main(String[] args) {
        String[] test = {"Vacation Times", "I'm Not as Active"};
        testAnagram(test);
    }

    public static void testAnagram(String[] input){
        String prep0 = prepare(input[0]);
        String prep1 = prepare(input[1]);
        if (prep0.equals(prep1)) {
            System.out.println(input[0] + " is an anagram of " + input[1]);
        } else {
            System.out.println(input[0] + " is NOT an anagram of " + input[1]);
        }
    }

    //returns input string with spaces removed and letters in alphabetical order
    public static String prepare(String s) {
        s = s.replaceAll("\\s", "") //remove spaces
            .replaceAll("[^a-zA-Z ]", "") //remove punctuation
            .toLowerCase();
        String result = "";
        String[] listS = s.split("");
        Arrays.sort(listS);
        for (String i : listS) {
            result = result.concat(i);
        }
        return result;
    }
}

//Convert numbers in base fib to base 10

class Numbers {
    public static void main(String[] args) {
        System.out.println(convert10(1001000));
        System.out.println(convert10(10101000));
        System.out.println(convert10(111111));
        System.out.println(convert10(100000));
    }

    public static int convert10(int f) {
        int[] digits = makeArr(f);
        int[] fibNums = fib(digits.length);
        int result = 0;

        for (int i = 0; i < digits.length; i++) {
            if (digits[i] == 1) {
                result += fibNums[digits.length-1-i];
            }
        }
        return result;
    }

    public static int[] makeArr(int n) {
        String numString = Integer.toString(n);
        int[] numArr = new int[numString.length()];
        for (int i = 0; i < numArr.length; i++) {
            char x = numString.charAt(i);
            numArr[i] = Character.getNumericValue(x);
        }
        return numArr;
    }

    public static int[] fib(int n) {
        if (n == 1) {
            int[] result = new int[1];
            result[0] = 1;
            return result;
        } else {
            int[] result = new int[n];
            result[0] = 1;
            result [1] = 1;
            for (int i = 2; i < n; i++) {
                result[i] = result[i-1] + result[i-2];
            }
            return result;
        }
    }
}



// Numbers in base fib | converted to base 10
// F 10                 1
// F 1                  1
// F 111111             20
// F 100000             8

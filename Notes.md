### Rules

1. Always care about worst case (look at he linear big O sample)
2. Drop the constants
    * O(5 + n/2 + 100) => O(n)
    * O(2n) => O(n)
3. Consecutive O(n) loops are total O(a + b) (Sample_3). Different terms for inputs
4. Nested O(n) loops are multiply O(a*b) (Quadratic Big O). Drop non dominants
5. Only care about the most dominant terms (Sample_5)
    * O(x^2+3x+100+x/2) => O(x^2)
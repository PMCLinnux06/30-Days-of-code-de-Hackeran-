using System;

class Solution {
    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        string binary = Convert.ToString(n, 2);
        int maxOnes = 0;
        int currentOnes = 0;

        foreach (char c in binary) {
            if (c == '1') {
                currentOnes++;
                if (currentOnes > maxOnes) {
                    maxOnes = currentOnes;
                }
            } else {
                currentOnes = 0;
            }
        }

        Console.WriteLine(maxOnes);
    }
}
